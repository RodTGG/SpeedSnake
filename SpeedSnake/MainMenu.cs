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

namespace SpeedSnake
{
    public partial class MainMenu : Form
    {
        public SoundPlayer Music;

        public MainMenu()
        {
            InitializeComponent();
            this.Icon = SpeedSnake.Properties.Resources.SnakeIcon;

            Music = new SoundPlayer(SpeedSnake.Properties.Resources.intro);
            Music.PlayLooping();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Game myGame = new Game(cbWalls.Checked);
            myGame.Show();
            this.Hide();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

        }
    }
}
