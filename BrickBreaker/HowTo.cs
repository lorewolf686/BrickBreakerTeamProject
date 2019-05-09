using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BrickBreaker
{
    public partial class HowTo : UserControl
    {
        SoundPlayer music = new SoundPlayer(Properties.Resources.backMusic);
        public HowTo()
        {
            InitializeComponent();
            music.PlayLooping();
            title.Location = new Point((this.Width - title.Width) / 2, 35);
        }

        private void HowTo_Load(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "GameScreen");
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "MenuScreen");
        }

        private void menuButton_Enter(object sender, EventArgs e)
        {
            menuButton.BackgroundImage = (Properties.Resources.purpbutton);
        }

        private void menuButton_Leave(object sender, EventArgs e)
        {
            menuButton.BackgroundImage = (Properties.Resources.button);
        }

        private void playButton_Enter(object sender, EventArgs e)
        {
            playButton.BackgroundImage = (Properties.Resources.purpbutton);
        }

        private void playButton_Leave(object sender, EventArgs e)
        {
            playButton.BackgroundImage = (Properties.Resources.button);
        }
    }
}
