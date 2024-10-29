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
    public partial class Recharge : Form
    {
        public Recharge()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            UsersHome usersHome = new UsersHome();
            usersHome.Show();
            this.Close();
        }

        private void Bkash_Click(object sender, EventArgs e)
        {
            Bkash bkash = new Bkash();
            bkash.Show();
            this.Close();
        }

        private void Nogod_Click(object sender, EventArgs e)
        {
            Nogod nogod = new Nogod();  
            nogod.Show();
            this.Close();
        }

        private void Upay_Click(object sender, EventArgs e)
        {
            Upay upay = new Upay();
            upay.Show();
            this.Close();
        }
    }
}
