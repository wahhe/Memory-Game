using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
//create by Wah He
//finished date: 2017.06.26
namespace Memory_Game
{
    public partial class f1 : Form
    {
        public static int cardsLeft, card1index, card2index, cardTurned;
        //add soundplayer
        public static System.Windows.Media.MediaPlayer backPlayer;
        public static System.Windows.Media.MediaPlayer bPlayer;
        public static System.Windows.Media.MediaPlayer flipPlayer;
        public static System.Windows.Media.MediaPlayer noMPlayer;

        public static string time = "";
                   
        public static Stopwatch playtime;
     
        public f1()
        {
            InitializeComponent();
            playtime = new Stopwatch();
           
           
        }

        private void MemoryGame_Load(object sender, EventArgs e)
        {
            MenuScreen ms = new MenuScreen();
            this.Controls.Add(ms);
        }

        private void easyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            easyScreen es = new easyScreen();
            f.Controls.Add(es);
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            mediumScreen ms = new mediumScreen();
            f.Controls.Add(ms);
        }

        private void hardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            hardScreen hs = new hardScreen();
            f.Controls.Add(hs);
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();    
        }

        private void closeB_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    



    
}
