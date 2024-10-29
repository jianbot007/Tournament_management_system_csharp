using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TournamentManagement
{
    public partial class Login : Form
    {

        public static string username;

        public Login()
        {
            InitializeComponent();
            

        }

      

       
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        
        

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


  


        private void LogicButton_Click_1(object sender, EventArgs e)
        {

            username = NameBox.Text;
            string password = PassWordBox.Text;
            
            
            string connectionString = "Data Source=Najib;Initial Catalog=najib;Integrated Security=True;";


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

               
                // Use parameterized query to prevent SQL injection
                string query = "SELECT COUNT(*) FROM info WHERE name = @username AND password = @password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameters
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        welcome w1 = new welcome();
                        w1.Show();
                        w1.GetValue(1);
                        MessageBox.Show("Log in Done .");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Incorrect username or password.");
                    }

                }
            }
        }

        private void RegistrationButton_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Close();
        }

        private void AboutUs_Click(object sender, EventArgs e)
        {
            AboutUs a=new AboutUs();
            a.Show();
            this.Close();
        }
    }
}
