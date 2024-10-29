using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TournamentManagement
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void TeamInformationButton_Click(object sender, EventArgs e)
        {
            Details details = new Details();
            details.Show();
            this.Close();
            details.call();
           
        }

        private void ManagerRegButton_Click(object sender, EventArgs e)
        {
            ManagerInformation m=new ManagerInformation();
            m.Show();
            this.Close();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            welcome w=new welcome();
            w.Show();
            this.Close();
        }
    }
}
