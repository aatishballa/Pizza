using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Tracker : Form
    {
        public Tracker()
        {
            InitializeComponent();
        }
        
        //
        
        private void Tracker_Load(object sender, EventArgs e)
        {
            play_music();
        }

        public void play_music() {
            SoundPlayer advertisemnt_1 = new SoundPlayer("1.wav");
            advertisemnt_1.Play();
        }
    }
}
