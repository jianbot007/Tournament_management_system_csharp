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
    public partial class ManagerInformation : Form
    {
        public ManagerInformation()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Close();
        }
        public void PointDataTable()
        {

            string connectionString = "Data Source=Najib;Initial Catalog=najib;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "Select * From TeamManagementId ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            da.Fill(table);
            InformationDataGridView.DataSource = table;
            con.Close();

        }
        private void InformationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
