using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class GameoverScreen : UserControl
    {
        public GameoverScreen()
        {
            InitializeComponent();

            f1.backPlayer = new System.Windows.Media.MediaPlayer();
            f1.backPlayer.Open(new Uri(Application.StartupPath + "/Resources/manyeah.wav"));
            f1.backPlayer.Play();

            
            outputlabel1.Text = "Your Used " + f1.time + " Seconds!";
        }

        private void playaginB_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            levelopitions los = new levelopitions();
            f.Controls.Add(los);
        }

        private void exitgameB_Click(object sender, EventArgs e)
        {
            f1.bPlayer = new System.Windows.Media.MediaPlayer();
            f1.bPlayer.Open(new Uri(Application.StartupPath + "/Resources/menu_gameover.wav"));
            f1.bPlayer.Play();
            Application.Exit();
        }

       // private void outputlabel1_Click(object sender, EventArgs e)
        
    }
}
