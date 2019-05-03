using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BrickBreaker
{
    public partial class HighScreen : UserControl
    {

		public HighScreen()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {

            Form form = this.FindForm();
            MenuScreen ms = new MenuScreen();

            ms.Location = new Point((form.Width - ms.Width) / 2, (form.Height - ms.Height) / 2);

            form.Controls.Add(ms);
            form.Controls.Remove(this);
        }

        private void HighScreen_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < 9; i++)
			{
				highScores.Text = i + ". " + Form1.highScores[i].name + " - " + Form1.highScores[i].score + "\n" + "\n";
			}	
		}

		

        private void allign()
        {

            menuButton.Location = new Point((this.Width - menuButton.Width) / 2, (this.Height - menuButton.Height) / 2);

        }
    }
}
