using System;
using System.Windows.Forms;

namespace TournamentManagement
{
    public partial class vedio : Form
    {
        public vedio()
        {
            InitializeComponent();
        }

        private void vedio_Load(object sender, EventArgs e)
        {
            // Play the video when the form loads
            string videoPath = @"C:\Users\najib\Desktop\TournamentManagement\TournamentManagement\Image\messi.mp4";
            PlayVideo(videoPath);
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            // This event is triggered when the control gains focus, you can add any related code here
        }

        private void PlayVideo(string videoPath)
        {
            axWindowsMediaPlayer1.URL = videoPath;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            welcome welcome = new welcome();
            welcome.Show();
            this.Close();
        }
    }
}
