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
    public partial class UsersHome : Form
    {


        private string userName;
        public string name;
        public UsersHome()
        {

            userName = Login.username;
            InitializeComponent();
            LoadUserData();
        }
        public void GetName(string username)
        {
            
            MessageBox.Show(userName);
            LoadUserData();
        }
        


        private void Recharge_Click(object sender, EventArgs e)
        {
            Recharge recharge = new Recharge();
            recharge.Show();
            this.Close();
        }

        private void AboutUS_Click(object sender, EventArgs e)
        {
            AboutUs about = new AboutUs();
            about.Show();
            this.Close();
        }

        private void TeamsINFO_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.Show();
            this.Close();
            details.callUser();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
           LoadUserData();  
        }

        private void BuyTicket_Click(object sender, EventArgs e)
        {
            BuyTicket buyTicket = new BuyTicket();
            buyTicket.Show();
            this.Close();
        }

        private void Welcome_Click(object sender, EventArgs e)
        {
            welcome welcome = new welcome();
            welcome.Show();
            welcome.GetValue(1);
            this.Close();
        }

        public void LoadUserData()
        {
            if (!string.IsNullOrEmpty(userName))
            {
                using (SqlConnection connection = new SqlConnection("Data Source=Najib;Initial Catalog=najib;Integrated Security=True;"))
                {
                    connection.Open();
                    string query = "SELECT name, balance, phone_no FROM info WHERE name = @username";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", userName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader["name"].ToString();
                                decimal balance = Convert.ToDecimal(reader["balance"]);
                                string phoneNo = reader["phone_no"].ToString();

                                NameLabel.Text = "Name: "+name;
                                BalanceLabel.Text ="Balance:"+ balance.ToString("C");
                               // PhoneNumberLabel.Text = phoneNo;
                            }
                            else
                            {
                                MessageBox.Show("User not found.");
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Username not provided.");
            }
        }



        private void UsersHome_Load(object sender, EventArgs e)
        {
            
        }

        private void PhoneNumberLabel_Click(object sender, EventArgs e)
        {
            // Action when the phone number label is clicked (if needed)
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void BalanceLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Setting s1=new Setting();
            s1.Show();
            this.Close();
        }
    }
}
