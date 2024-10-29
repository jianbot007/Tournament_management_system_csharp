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
using System.Xml.Linq;

namespace TournamentManagement
{
   
    public partial class TeamManagmentLogin : Form
    {
        
        public TeamManagmentLogin()
        {
            InitializeComponent();
        }

        private void TeamManagmentLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

        private void TeamManagmentLogicButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=Najib;Initial Catalog=najib;Integrated Security=True;";
            string username = TeamManagmentNameBox.Text;
            string password = TeamManagmentPassWordBox.Text;

            // Query to check if the username and password exist in the database
            string query = "SELECT COUNT(*) FROM TeamManagementId WHERE username = @username AND password = @password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {
                        //  TeamManagment A = new TeamManagment(); // Initialize the TeamManagment form
                        // A.Input(GetTeamCounter(username)); // Set the counter based on the username
                        if (username == "TeamA")
                        {
                            TeamA t= new TeamA();
                            t.Show();
                            this.Close();
                        }
                       else if (username == "TeamB")
                        {
                            TeamB t = new TeamB();
                            t.Show();
                            this.Close();
                        }

                        else if (username == "TeamC")
                        {
                            TeamC t = new TeamC();
                            t.Show();
                            this.Close();
                        }
                        else if (username == "TeamD")
                        {
                            TeamD t = new TeamD();
                            t.Show();
                            this.Close();
                        }
                        else if (username == "TeamE")
                        {
                            TeamE t = new TeamE();
                            t.Show();
                            this.Close();
                        }
                        else if (username == "TeamF")
                        {
                            TeamF t = new TeamF();
                            t.Show();
                            this.Close();
                        }
                        else if (username == "TeamG")
                        {
                            TeamG t = new TeamG();
                            t.Show();
                            this.Close();
                        }
                        MessageBox.Show("Login successful!");
                      //  A.Show(); // Show the TeamManagment form
                        this.Close(); // Hide the current login form
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        // Method to get the counter value based on the username
      /*  private int GetTeamCounter(string username)
        {
            switch (username)
            {
                case "TeamA":
                    return 1;
                case "TeamB":
                    return 2;
                case "TeamC":
                    return 3;
                case "TeamD":
                    return 4;
                case "TeamE":
                    return 5;
                case "TeamF":
                    return 6;
                case "TeamG":
                    return 7;
                default:
                    return 0; // Return 0 if the username doesn't match any of the predefined teams
            }
        }

        */

        private void TeamManagmentPassWordBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
