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
using System.Threading;
using System.IO;

namespace Memory_Game
{
    public partial class MenuScreen : UserControl
    {

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
        public MenuScreen()
        {
            InitializeComponent();
            soundL();
            
        }
            

        private void startB_Click(object sender, EventArgs e)
        {
            //add button sound
            f1.bPlayer.Play();
            //stop background music
            f1.backPlayer.Stop();
            //Thread.Sleep(400);        

            Form f = this.FindForm();
            f.Controls.Remove(this);

            levelopitions los = new levelopitions();
            f.Controls.Add(los);
           
        }

        private void exitB_Click(object sender, EventArgs e)
        {
            //add sound   
            f1.bPlayer.Play();
            f1.backPlayer.Stop();

            Application.Exit();
        }
    }
}
