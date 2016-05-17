using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Loopy
{
    public partial class Form1 : Form
    {
        private SoundPlayer player;
        private string path;
        public Form1()
        {
            InitializeComponent();
            //player = new SoundPlayer();
            player = new SoundPlayer(Loopy.Properties.Resources.loop_01);
            path = Environment.SpecialFolder.UserProfile.ToString() + @"\Music";
            path = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%") + @"\Music";
            //player.SoundLocation = path + @"\loop-01.wav";
            statusBar.Text = player.SoundLocation;
            notifyIcon1.BalloonTipTitle = "Noise Loop";
            notifyIcon1.BalloonTipText = "Right Click for Menu";            
            notifyIcon1.ShowBalloonTip(1000);
            WindowState = FormWindowState.Minimized;
            this.ShowInTaskbar = false;
        }

        private void start_Click(object sender, EventArgs e)
        {
            player.PlayLooping();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
        
        private void toolStripExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripStart_Click(object sender, EventArgs e)
        {
            player.PlayLooping();
        }

        private void toolStripStop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void toolStripRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }
    }
}
