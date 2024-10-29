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
    public partial class TeamF : Form
    {
        public TeamF()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////////////////////// Panel///////////////////////////////////////////////////////////

        private void PlayerPanel_Paint(object sender, PaintEventArgs e)
        {
            AddPlayer.Visible = true;
            RemovePlayer.Visible = true;
        }


        private void StaffPanel_Paint(object sender, PaintEventArgs e)
        {
            AddStaff.Visible = true;
            RemoveStaff.Visible = true;
        }

        //////////////////////////////////////////////////////////////////TeamF///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////Player////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //FIRST ,YOU HAVE TO ADD DATABASE VIEW 
        private void FillPlayerInformationF()
        {
            string connectionString = "Data Source=Najib;Initial Catalog=najib;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "Select * From playerDetailsF";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PlayerdataGridView.DataSource = dt;
            PlayerdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }
        //SECOND,MAKE THE ARGUMENT 
        public void AddPlayersF()
        {
            string connectionString = "Data Source=Najib;Initial Catalog=najib;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                foreach (DataGridViewRow row in PlayerdataGridView.Rows)
                {
                    if (!row.IsNewRow && row.Cells["jersey_no"].Value != null && row.Cells["name"].Value != null &&
                        row.Cells["country"].Value != null && row.Cells["playing_role"].Value != null)
                    {
                        int jersey_no = Convert.ToInt32(row.Cells["jersey_no"].Value);
                        string name = row.Cells["name"].Value.ToString();
                        string country = row.Cells["country"].Value.ToString();
                        string playing_role = row.Cells["playing_role"].Value.ToString();

                        // Check if the jersey number already exists in the database
                        bool jerseyExists = false;
                        foreach (DataGridViewRow prevRow in PlayerdataGridView.Rows)
                        {
                            if (!prevRow.IsNewRow && prevRow.Index != row.Index)
                            {
                                int prevJerseyNo = Convert.ToInt32(prevRow.Cells["jersey_no"].Value);
                                if (jersey_no == prevJerseyNo)
                                {
                                    jerseyExists = true;
                                    break;
                                }
                            }
                        }

                        if (jerseyExists)
                        {
                            MessageBox.Show("Jersey number " + jersey_no + " already exists. Please choose another jersey number.");
                            break;
                        }

                        // Insert a new record
                        string insertQuery = "INSERT INTO playerDetailsF (jersey_no, name, country, playing_role) " +
                                             "VALUES (@jersey_no, @name, @country, @playing_role)";

                        SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                        insertCmd.Parameters.AddWithValue("@jersey_no", jersey_no);
                        insertCmd.Parameters.AddWithValue("@name", name);
                        insertCmd.Parameters.AddWithValue("@country", country);
                        insertCmd.Parameters.AddWithValue("@playing_role", playing_role);

                        try
                        {
                            insertCmd.ExecuteNonQuery();
                            MessageBox.Show("Changes saved successfully!");
                            break;
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show("Error inserting data: " + ex.Message);
                        }
                    }
                }


            }
        }



        private void RemovePlayersF()
        {
            if (PlayerdataGridView.SelectedCells.Count > 0)
            {
                // Get the index of the selected cell
                int selectedRowIndex = PlayerdataGridView.SelectedCells[0].RowIndex;

                // Get the value in the "jersey_no" column of the selected row
                int jersey_no = Convert.ToInt32(PlayerdataGridView.Rows[selectedRowIndex].Cells["jersey_no"].Value);

                // Remove the row from the dataGridView1
                PlayerdataGridView.Rows.RemoveAt(selectedRowIndex);

                // Remove the corresponding row from the database
                string connectionString = "Data Source=Najib;Initial Catalog=najib;Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM playerDetailsF WHERE jersey_no = @jersey_no;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@jersey_no", jersey_no);
                    cmd.ExecuteNonQuery();
                }
            }
            else
            {
                MessageBox.Show("Please select a cell in the 'jersey_no' column to remove.");
            }
        }

        /////////////////////////////////////////STAFFS///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





        private void FillStaffsInformationF()
        {
            string connectionString = "Data Source=Najib;Initial Catalog=najib;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT * FROM staffsF";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            StaffdataGridView.DataSource = dt; // Updated line to set the DataSource to StaffdataGridView
            StaffdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            con.Close();
        }


        public void AddStaffsF()
        {
            string connectionString = "Data Source=Najib;Initial Catalog=najib;Integrated Security=True;";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                foreach (DataGridViewRow row in StaffdataGridView.Rows)
                {
                    if (!row.IsNewRow && row.Cells["id"].Value != null && row.Cells["name"].Value != null &&
                        row.Cells["role"].Value != null)
                    {
                        int id = Convert.ToInt32(row.Cells["id"].Value);
                        string name = row.Cells["name"].Value.ToString();
                        string role = row.Cells["role"].Value.ToString();

                        // Check if the id already exists in any of the previous rows
                        bool idExists = false;
                        foreach (DataGridViewRow prevRow in StaffdataGridView.Rows)
                        {
                            if (!prevRow.IsNewRow && prevRow.Index != row.Index)
                            {
                                int prevId = Convert.ToInt32(prevRow.Cells["id"].Value);
                                if (id == prevId)
                                {
                                    idExists = true;
                                    break;
                                }
                            }
                        }

                        if (idExists)
                        {
                            MessageBox.Show("Staff with ID " + id + " already exists.");
                            break;
                            //continue; // Skip this row and proceed with the next one
                        }

                        // Insert a new record
                        string insertQuery = @"
                    INSERT INTO staffsF (id, name, role) 
                    VALUES (@id, @name, @role);";
                        using (SqlCommand insertCmd = new SqlCommand(insertQuery, con))
                        {
                            insertCmd.Parameters.AddWithValue("@id", id);
                            insertCmd.Parameters.AddWithValue("@name", name);
                            insertCmd.Parameters.AddWithValue("@role", role);

                            try
                            {
                                insertCmd.ExecuteNonQuery();

                                MessageBox.Show("Staff members added successfully!");
                                break;
                            }
                            catch (Exception ex)
                            {

                            }

                        }
                    }
                }

            }
        }


        private void RemoveStaffsF()
        {
            if (StaffdataGridView.SelectedCells.Count > 0) // Updated line to use StaffdataGridView
            {
                // Get the index of the selected cell
                int selectedRowIndex = StaffdataGridView.SelectedCells[0].RowIndex; // Updated line to use StaffdataGridView

                // Get the value in the "id" column of the selected row
                int id = Convert.ToInt32(StaffdataGridView.Rows[selectedRowIndex].Cells["id"].Value); // Updated line to use StaffdataGridView

                // Remove the row from the StaffdataGridView
                StaffdataGridView.Rows.RemoveAt(selectedRowIndex); // Updated line to use StaffdataGridView

                // Remove the corresponding row from the database
                string connectionString = "Data Source=Najib;Initial Catalog=najib;Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "DELETE FROM staffsF WHERE id = @id;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Staff member removed successfully!");
            }
            else
            {
                MessageBox.Show("Please select a cell in the 'id' column to remove.");
            }
        }



        private void Staffs_Click(object sender, EventArgs e)
        {
            StaffdataGridView.Visible = true;
            PlayerPanel.Visible = false;
            StaffPanel.Visible = true;
            FillStaffsInformationF();
        }
        private void RemoveStaff_Click(object sender, EventArgs e)
        {
            RemoveStaffsF();
        }

        private void AddStaff_Click(object sender, EventArgs e)
        {
            AddStaffsF();
        }

      
    
        private void Players_Click(object sender, EventArgs e)
        {
            PlayerPanel.Visible = true;
            StaffPanel.Visible = false;
            PlayerdataGridView.Visible = true;
            FillPlayerInformationF();
        }
        private void RemovePlayer_Click(object sender, EventArgs e)
        {
            RemovePlayersF();
        }

        private void AddPlayer_Click(object sender, EventArgs e)
        {
            AddPlayersF();
        }

    
      
        private void Logout_Click(object sender, EventArgs e)
        {
            TeamManagmentLogin  team=new TeamManagmentLogin();  
            team.Show();
            this.Close();
        }

        private void Welcomee_Click(object sender, EventArgs e)
        {
            welcome welcome = new welcome();
            welcome.Show();
            this.Close();
        }

        private void StaffdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void PlayerdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
