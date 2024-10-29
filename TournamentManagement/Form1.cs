using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TournamentManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void PassWordBox_TextChanged(object sender, EventArgs e)
        {

          

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Najib;Initial Catalog=najib;Integrated Security=True;";

            string name = NameBox.Text;
            string phone_no = NumberBox.Text;
            string password = PassWordBox.Text;
            string confirmPassword = ConfirmBox.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Check if the username already exists in the database
                string checkUsernameQuery = "SELECT COUNT(*) FROM info WHERE name = @name";
                using (SqlCommand checkUsernameCmd = new SqlCommand(checkUsernameQuery, con))
                {
                    checkUsernameCmd.Parameters.AddWithValue("@name", name);
                    int existingUsernameCount = (int)checkUsernameCmd.ExecuteScalar();

                    if (existingUsernameCount > 0)
                    {
                        MessageBox.Show("Username already exists. Please enter a different username.");
                        return; // Exit the method if username exists
                    }
                }

                // Check if the phone number already exists in the database
                string checkPhoneQuery = "SELECT COUNT(*) FROM info WHERE phone_no = @phone_no";
                using (SqlCommand checkPhoneCmd = new SqlCommand(checkPhoneQuery, con))
                {
                    checkPhoneCmd.Parameters.AddWithValue("@phone_no", phone_no);
                    int existingPhoneCount = (int)checkPhoneCmd.ExecuteScalar();

                    if (existingPhoneCount > 0)
                    {
                        MessageBox.Show("Phone number already exists. Please enter a different phone number.");
                        return; // Exit the method if phone number exists
                    }
                }

                // Proceed with insertion if both username and phone number are unique
                if (confirmPassword == password)
                {
                    string insertQuery = "INSERT INTO info (name, phone_no, password, confirm_password) " +
                                         "VALUES (@name, @phone_no, @password, @confirmPassword)";
                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                    {
                        insertCmd.Parameters.AddWithValue("@name", name);
                        insertCmd.Parameters.AddWithValue("@phone_no", phone_no);
                        insertCmd.Parameters.AddWithValue("@password", password);
                        insertCmd.Parameters.AddWithValue("@confirmPassword", confirmPassword);
                        insertCmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Data inserted successfully!");
                }
                else
                {
                    MessageBox.Show("Passwords do not match. Please confirm your password.");
                }
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Close();
        }

        private void Passoword_Click(object sender, EventArgs e)
        {

        }

        private void NumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
