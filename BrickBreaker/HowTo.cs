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
    }
}
