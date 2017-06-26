using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;


namespace Memory_Game
{
    public partial class levelopitions : UserControl
    {

        public levelopitions()
        {
            InitializeComponent();
            soundL();
            
        }
        public void soundL()
        {
            //add background soundplayer
            f1.backPlayer = new System.Windows.Media.MediaPlayer();
            f1.backPlayer.Open(new Uri(Application.StartupPath + "/Resources/gamescreen_level.wav"));
            f1.backPlayer.Play();
            //add button musicplayer
            f1.bPlayer = new System.Windows.Media.MediaPlayer();
            f1.bPlayer.Open(new Uri(Application.StartupPath + "/Resources/menuselect.wav"));           

        }
        private void easyB_Click(object sender, EventArgs e)
        {
            //add sound
            f1.bPlayer.Play();
            f1.backPlayer.Stop();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            easyScreen es = new easyScreen();
            f.Controls.Add(es);
        }

        private void mediumB_Click(object sender, EventArgs e)
        {
            //add sound
            f1.bPlayer.Play();
            f1.backPlayer.Stop();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            mediumScreen ms = new mediumScreen();
            f.Controls.Add(ms);
        }

        private void hardB_Click(object sender, EventArgs e)
        {
            //add sound
            f1.bPlayer.Play();
            f1.backPlayer.Stop();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            hardScreen hs = new hardScreen();
            f.Controls.Add(hs);
        }
    }
}
