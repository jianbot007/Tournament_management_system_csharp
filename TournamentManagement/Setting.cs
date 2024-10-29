using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TournamentManagement
{
    public partial class Setting : Form
    {
        public string userName=Login.username;
        public Setting()
        {
            InitializeComponent();
            InformationDataTable();
            PointDataTable();

            

            }
        public void PointDataTable()
        {

            // Connection string
            string connectionString = "Data Source=Najib;Initial Catalog=najib;Integrated Security=True;";

            // Create SqlConnection object
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Open the connection
                con.Open();

                // SQL query with parameter
                string query = "SELECT * FROM info WHERE name = @Name";

                // Create SqlDataAdapter and pass the query and connection
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    // Add parameter to the command
                    da.SelectCommand.Parameters.AddWithValue("@Name", userName); // Use the passed username parameter

                    // Create DataTable to hold the results
                    DataTable table = new DataTable();

                    // Fill the DataTable with data from the query
                    da.Fill(table);

                    // Set the DataGridView's DataSource to the DataTable
                    InformationDataGridView.DataSource = table;

                    // Automatically resize the columns to fit the content
                    InformationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }

        }



      
        public void InformationDataTable()
        {
            // Connection string
            string connectionString = "Data Source=Najib;Initial Catalog=najib;Integrated Security=True;";

            // Create SqlConnection object
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Open the connection
                con.Open();

                // SQL query with parameter
                string query = "SELECT * FROM info WHERE name = @UserName";

                // Create SqlCommand and pass the query and connection
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    // Add parameter
                    cmd.Parameters.AddWithValue("@UserName", userName);

                    // Execute the query
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Populate text boxes
                            NameTextBox.Text = reader["name"].ToString();
                            MobileTextBox.Text = reader["phone_no"].ToString();
                            PassWordTextBox.Text = reader["password"].ToString();
                            ConfirmPasswordTextBox.Text = reader["phone_no"].ToString();
                        }
                        else
                        {
                            // Close the connection if no records found
                            con.Close();
                        }
                    }
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            // Connection string
            string connectionString = "Data Source=Najib;Initial Catalog=najib;Integrated Security=True;";

            // Create SqlConnection object
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Open the connection
                con.Open();

                // SQL query to update the record
                string query = "UPDATE info SET phone_no = @PhoneNo, password = @Password WHERE name = @UserName";

                // Create SqlCommand and pass the query and connection
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@PhoneNo", MobileTextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", PassWordTextBox.Text);
                    cmd.Parameters.AddWithValue("@UserName", NameTextBox.Text);

                    // Execute the update query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record updated successfully.");
                        PointDataTable();
                        // You might want to update the DataGridView or perform other actions after successful update
                    }
                    else
                    {
                        MessageBox.Show("Failed to update record.");
                    }
                }
            }
        }





        private void Setting_Load(object sender, EventArgs e)
        {

        }

        private void InformationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DelectButton_Click(object sender, EventArgs e)
        {

        
            // Get the username from the NameTextBox
            string userName = NameTextBox.Text;

            if (!string.IsNullOrEmpty(userName))
            {
                // Call the method to delete the row
                DeleteRow(userName);
            }
            else
            {
                MessageBox.Show("Please enter a username to delete.");
            }
        }

        private void DeleteRow(string userName)
        {
            // Connection string
            string connectionString = "Data Source=Najib;Initial Catalog=najib;Integrated Security=True;";

            // Create SqlConnection object
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Open the connection
                con.Open();

                // SQL query to delete the record
                string query = "DELETE FROM info WHERE name = @UserName";

                // Create SqlCommand and pass the query and connection
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameter
                    cmd.Parameters.AddWithValue("@UserName", userName);

                    // Execute the delete query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                        PointDataTable();
                        welcome w1 = new welcome();
                        w1.Show();
                        this.Close();
                        // You might want to update the DataGridView or perform other actions after successful deletion
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete record.");
                    }
                }
            }

            // Clear text boxes after deleting the row
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            // Clear all text boxes
            NameTextBox.Text = "";
            MobileTextBox.Text = "";
            PassWordTextBox.Text = "";
            ConfirmPasswordTextBox.Text = "";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            UsersHome usersHome = new UsersHome();
            usersHome.Show();
            this.Close();
        }
    }
}
