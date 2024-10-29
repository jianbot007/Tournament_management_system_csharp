using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentManagement
{
    public partial class Bkash : Form
    {
        public Bkash()
        {
            InitializeComponent();
        }

        private void UserNoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Userno_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Recharge r= new Recharge();
            r.Show();
            this.Close();   
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            float amount = Convert.ToSingle(ammountText.Text);
            string username = UserNoBox.Text;

            // Ensure that username is not null or empty
            if (!string.IsNullOrEmpty(username))
            {
                // Connect to the database using the provided connection string
                using (SqlConnection connection = new SqlConnection("Data Source=Najib;Initial Catalog=najib;Integrated Security=True;"))
                {
                    // Open the connection
                    connection.Open();

                    // Find the phone number corresponding to the provided username
                    string query = "SELECT phone_no FROM info WHERE name = @username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@username", username);

                    // Execute the query and get the phone number
                    string phoneNumber = command.ExecuteScalar() as string;

                    // Check if a phone number was found
                    if (!string.IsNullOrEmpty(phoneNumber))
                    {
                        // Update the balance for the found phone number
                        string updateBalanceQuery = "UPDATE info SET balance = balance + @amount WHERE phone_no = @phoneNumber";
                        SqlCommand updateBalanceCommand = new SqlCommand(updateBalanceQuery, connection);
                        updateBalanceCommand.Parameters.AddWithValue("@amount", amount);
                        updateBalanceCommand.Parameters.AddWithValue("@phoneNumber", phoneNumber);

                        try
                        {
                            // Execute the update balance query
                            int rowsAffected = updateBalanceCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Amount added successfully.");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add amount. Phone number may not exist in the database.");
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error executing SQL query: " + ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username not found.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a username.");
            }
        }



        private void ammount_Click(object sender, EventArgs e)
        {

        }

        private void ammountText_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nogodMobileNum_Click(object sender, EventArgs e)
        {

        }
    }
}
