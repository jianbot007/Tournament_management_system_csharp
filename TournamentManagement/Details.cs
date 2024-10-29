using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TournamentManagement
{
    public partial class Details : Form
    {
        public int counter;

        public Details()
        {
            InitializeComponent();
           
            // PointTable.RowTemplate.Height = 33;
        }
        public void Elements()
        {
            PointDataTable();
            PLayerName();
            staffName();
            PlayerdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            CoachdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PointTabledataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }

        public  void call()
        {
            Admin.Visible = true;
            User.Visible = false ;
        }

        public void callUser()
        {
            User.Visible = true;
            Admin.Visible=false;
        }

        public void PointDataTable()
        {

            string connectionString = "Data Source=Najib;Initial Catalog=najib;Integrated Security=True;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "Select * From point";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable table = new DataTable();
            da.Fill(table);
            PointTabledataGridView.DataSource = table;
            con.Close();

        }

        public  void PLayerName()
        {
            string connectionStringg = "Data Source=Najib;Initial Catalog=najib;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connectionStringg);
            conn.Open();

            if (counter == 1)
            {
                string query = "Select * From playerDetailsA";
                SqlDataAdapter daa = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                daa.Fill(table);
                PlayerdataGridView.DataSource = table;

            }
            else if (counter == 2)
            {
                string query = "Select * From playerDetailsB";
                SqlDataAdapter daa = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                daa.Fill(table);
                PlayerdataGridView.DataSource = table;

            }
            else if (counter == 3)
            {
                string query = "Select * From playerDetailsC";
                SqlDataAdapter daa = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                daa.Fill(table);
                PlayerdataGridView.DataSource = table;

            }
            else if (counter == 4)
            {
                string query = "Select * From playerDetailsD";
                SqlDataAdapter daa = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                daa.Fill(table);
                PlayerdataGridView.DataSource = table;

            }
            else if (counter == 5)
            {
                string query = "Select * From playerDetailsE";
                SqlDataAdapter daa = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                daa.Fill(table);
                PlayerdataGridView.DataSource = table;

            }
            else if (counter == 6)
            {
                string query = "Select * From playerDetailsF";
                SqlDataAdapter daa = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                daa.Fill(table);
                PlayerdataGridView.DataSource = table;

            }
            else if (counter == 7)
            {
                string query = "Select * From playerDetailsG";
                SqlDataAdapter daa = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                daa.Fill(table);
                PlayerdataGridView.DataSource = table;

            }
            conn.Close();

        }

        public void staffName()
        {

            string connectionStringgg = "Data Source=Najib;Initial Catalog=najib;Integrated Security=True;";
            SqlConnection connn = new SqlConnection(connectionStringgg);
            connn.Open();

            if (counter == 1)
            {
                string query = "Select * From staffsA ";
                SqlDataAdapter daa = new SqlDataAdapter(query, connn);
                DataTable table = new DataTable();
                daa.Fill(table);
               CoachdataGridView.DataSource = table;

            }
          else  if (counter == 2)
            {
                string query = "Select * From staffsB ";
                SqlDataAdapter daa = new SqlDataAdapter(query, connn);
                DataTable table = new DataTable();
                daa.Fill(table);
                CoachdataGridView.DataSource = table;

            }
           else if (counter == 3)
            {
                string query = "Select * From staffsC ";
                SqlDataAdapter daa = new SqlDataAdapter(query, connn);
                DataTable table = new DataTable();
                daa.Fill(table);
                CoachdataGridView.DataSource = table;

            }
           else if (counter == 4)
            {
                string query = "Select * From staffsD";
                SqlDataAdapter daa = new SqlDataAdapter(query, connn);
                DataTable table = new DataTable();
                daa.Fill(table);
                CoachdataGridView.DataSource = table;

            }
           else if (counter == 5)
            {
                string query = "Select * From staffsE ";
                SqlDataAdapter daa = new SqlDataAdapter(query, connn);
                DataTable table = new DataTable();
                daa.Fill(table);
                CoachdataGridView.DataSource = table;

            }
           else if (counter == 6)
            {
                string query = "Select * From staffsF ";
                SqlDataAdapter daa = new SqlDataAdapter(query, connn);
                DataTable table = new DataTable();
                daa.Fill(table);
                CoachdataGridView.DataSource = table;

            }
           else if (counter == 7)
            {
                string query = "Select * From staffsG ";
                SqlDataAdapter daa = new SqlDataAdapter(query, connn);
                DataTable table = new DataTable();
                daa.Fill(table);
                CoachdataGridView.DataSource = table;

            }
           
            connn.Close();


        }
        private void TeamAPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PlayerdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CoachdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string serach=SearchTextBox.Text;
            if (serach == "TeamA" || serach == "A")
            {
                counter = 1;
            }
            else if (serach == "TeamB" || serach == "B")
            {
                counter = 2;
            }
            else if (serach == "TeamC" || serach == "C")
            {
                counter = 3;
            }
            else if (serach == "TeamD" || serach == "D")
            {
                counter = 4;
            }
            else if (serach == "TeamE" || serach == "E")
            {
                counter = 5;
            }
            else if (serach == "TeamF" || serach == "F")
            {
                counter = 6;
            }
            else if (serach == "TeamG" || serach == "G")
            {
                counter = 7;
            }
            Elements();
        }

        private void Welcome_Click(object sender, EventArgs e)
        {
            welcome welcome = new welcome();
            welcome.GetValue(1);
            welcome.Show();
            this.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            UsersHome u1=new UsersHome();
            u1.Show();
            this.Close();
        }

        private void Admin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Details_Load(object sender, EventArgs e)
        {

        }

       

        private void AdminBackButton_Click(object sender, EventArgs e)
        {
            Admin a = new Admin();
            a.Show();

            this.Close();
        }
    }
}
