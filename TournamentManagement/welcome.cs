using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentManagement
{ 
    public partial class welcome : Form
    {

        
        
        public welcome()
        {
            InitializeComponent();
            PointDataTable();
            PointTable.RowTemplate.Height = 33;
            LoginButtonsPanel.Visible = false;

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
            PointTable.DataSource = table;
            con.Close();

        }
      




        private void Login_Click(object sender, EventArgs e)
        {
            LoginButtonsPanel.Visible = true;
        }

        private void welcome_Load(object sender, EventArgs e)
        {
            PointDataTable();
        }



        private void AdPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PointTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //take a picture box 
        //have to take image list & drop it to picture box 
        // take a timers same as image list drop it at picture box 
        private int count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (count < 4)
            {

                pictureBox1.Image = imageList1.Images[count];
                count++;
            }

            else
            {
                count = 0;

            }

        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        public int getNo = 0;
        public void GetValue(int no)
        {
            getNo = no;
        }
        private void AccountSettings_Click(object sender, EventArgs e)
        {
            if ( getNo > 0 )
            {
                UsersHome usersHome=new UsersHome();
               
                usersHome.Show();
               
                this.Hide();

            }

            else
            {
                Login l1    = new Login();  
                l1.Show();
                this.Close();
            }

        }

        private void LOGOUT_Click(object sender, EventArgs e)
        {
            getNo = 0;
            this.Refresh();
        }

        private void User_Click(object sender, EventArgs e)
        {
            Login l1 = new Login();
            l1.Show();
            this.Close();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginButtonsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginButtonsPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LoginButtonsPanel.Visible = false;
        }

        private void Managment_Click(object sender, EventArgs e)
        {
            TeamManagmentLogin t1= new TeamManagmentLogin();
            t1.Show();
            this.Close();
        }

        private void LeftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LiveShow_Click(object sender, EventArgs e)
        {
            if (getNo > 0)
            {
                vedio vedio = new vedio();
                vedio.Show();
                this.Close();

            }

            else
            {
                Login l1 = new Login();
                l1.Show();
                this.Close();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FixedPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
