using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TournamentManagement
{
    public partial class BuyTicket : Form
    {
        public BuyTicket()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            // Close the form or perform other cancellation logic
            this.Close();
        }

        private void Quantity_ValueChanged(object sender, EventArgs e)
        {
            // Handle quantity change, if needed
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            decimal ticketPrice = 120; // Assuming the ticket price is fixed

            // Parse the quantity entered by the user
            int quantity;
            if (!int.TryParse(Quantity.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            // Check if the username and mobile number are not empty
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a username.");
                return;
            }

            // Calculate the total ticket price
            decimal totalTicketPrice = ticketPrice * quantity;

            // Call the PurchaseTicket method to handle the purchase logic
            PurchaseTicket(username, totalTicketPrice);
        }


        private void PurchaseTicket(string username, decimal totalTicketPrice)
        {
            // Check if the user exists in the database
            using (SqlConnection connection = new SqlConnection("Data Source=Najib;Initial Catalog=najib;Integrated Security=True;"))
            {
                connection.Open();
                string query = "SELECT balance FROM info WHERE name = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        decimal balance = Convert.ToDecimal(result);
                        if (balance >= totalTicketPrice)
                        {
                            // Sufficient balance to purchase tickets
                            decimal newBalance = balance - totalTicketPrice;
                            // Update the balance in the database
                            UpdateBalance(connection, username, newBalance);
                            MessageBox.Show($"Tickets purchased successfully. Total price: {totalTicketPrice:C}. New balance: {newBalance:C}");
                        }
                        else
                        {
                            MessageBox.Show("Insufficient balance to purchase tickets.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
            }
        }

        private void UpdateBalance(SqlConnection connection, string username, decimal newBalance)
        {
            // Update the balance in the database
            string updateQuery = "UPDATE info SET balance = @newBalance WHERE name = @username";
            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
            {
                updateCommand.Parameters.AddWithValue("@newBalance", newBalance);
                updateCommand.Parameters.AddWithValue("@username", username);
                updateCommand.ExecuteNonQuery();
            }
        }

        private void BuyTicket_Load(object sender, EventArgs e)
        {
            // Any initialization logic for the form can go here
        }

        private void usernameBox_TextChanged(object sender, EventArgs e)
        {
            // Handle username text changed event, if needed
        }

        private void mobilenoBox_TextChanged(object sender, EventArgs e)
        {
            // Handle mobile number text changed event, if needed
        }

        private void Payment_Click(object sender, EventArgs e)
        {
            // Call the PurchaseButton_Click method when the payment button is clicked
            PurchaseButton_Click(sender, e);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            UsersHome usersHome = new UsersHome();
            usersHome.Show();
            this.Close();
        }
    }
}
