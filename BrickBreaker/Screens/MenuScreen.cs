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
    public partial class MenuScreen : UserControl
    {

        SoundPlayer music = new SoundPlayer(Properties.Resources.backMusic);

        public MenuScreen()
        {
            InitializeComponent();
            lorenAlignment();
            music.PlayLooping();          
           
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            music.Stop();
            // Goes to the game screen  
            Form1.ChangeScreen(this,"GameScreen");
        }

        private void lorenAlignment()
        {
            playButton.Location = new Point((this.Width - playButton.Width) / 2, 240);

            how.Location = new Point((this.Width - how.Width) / 2, 320);

            coopBox.Location = new Point((this.Width - playButton.Width) / 2 + 40, 240);

            exitButton.Location = new Point((this.Width - exitButton.Width) / 2, 400);
            title.Location = new Point((this.Width - title.Width) / 2, 130);
        }

		
		private void nameButton_Click(object sender, EventArgs e)
		{
			Form1.ChangeScreen(this, "NameScreen");
		}

        private void highButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "HighScreen");
        }

        private void coopBox_CheckedChanged(object sender, EventArgs e)
        {
            if (coopBox.Checked == true)
            {
                Form1.twoPlayer = true;
            }
            else
            {
                Form1.twoPlayer = false;
            }
        }

        private void how_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, "HowTo");
        }

        private void how_Enter(object sender, EventArgs e)
        {
            how.BackgroundImage = (Properties.Resources.purpbutton);
        }

        private void how_Leave(object sender, EventArgs e)
        {
            how.BackgroundImage = (Properties.Resources.button);
        }

        private void playButton_Enter(object sender, EventArgs e)
        {
            playButton.BackgroundImage = (Properties.Resources.purpbutton);
        }

        private void playButton_Leave(object sender, EventArgs e)
        {
            playButton.BackgroundImage = (Properties.Resources.button);
        }

        private void exitButton_Enter(object sender, EventArgs e)
        {
            exitButton.BackgroundImage = (Properties.Resources.purpbutton);
        }

        private void exitButton_Leave(object sender, EventArgs e)
        {
            exitButton.BackgroundImage = (Properties.Resources.button);
        }

        private void coopBox_Enter(object sender, EventArgs e)
        {
            coopBox.BackgroundImage = (Properties.Resources.purpbutton);
        }

        private void coopBox_Leave(object sender, EventArgs e)
        {
            coopBox.BackgroundImage = null;
        }
    }
}
