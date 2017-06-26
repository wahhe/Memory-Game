using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Media;


namespace Memory_Game
{
    public partial class hardScreen : UserControl
    {
        private List<Cards> cardListH = new List<Cards>();

        public hardScreen()
        {
            InitializeComponent();
            OnStartHard();
            
            sound();
        }
        public void sound()
        {
            //add background soundplayer
            f1.backPlayer = new System.Windows.Media.MediaPlayer();
            f1.backPlayer.Open(new Uri(Application.StartupPath + "/Resources/gamescreen.wav"));
            f1.backPlayer.Play();
            //add button musicplayer
            f1.bPlayer = new System.Windows.Media.MediaPlayer();
            f1.bPlayer.Open(new Uri(Application.StartupPath + "/Resources/menuselect.wav"));
            // add flip cards musicplayer
            f1.flipPlayer = new System.Windows.Media.MediaPlayer();
            f1.flipPlayer.Open(new Uri(Application.StartupPath + "/Resources/flip.wav"));
            //add non-match sound
            f1.noMPlayer = new System.Windows.Media.MediaPlayer();
            f1.noMPlayer.Open(new Uri(Application.StartupPath + "/Resources/not matched.wav"));

        }

        private void OnStartHard()
        {
            //count time
            f1.playtime.Start();

            easyScreen.cardTurned = 0;
            easyScreen.cardsLeft = 20;

            cleft.Text = easyScreen.cardsLeft + " cards left";

            Cards card1 = new Memory_Game.Cards("poo", Properties.Resources.poo, Properties.Resources.Qmark);
            Cards card2 = new Memory_Game.Cards("thump", Properties.Resources.thump_up, Properties.Resources.Qmark);
            Cards card3 = new Memory_Game.Cards("flowers", Properties.Resources.flowers, Properties.Resources.Qmark);
            Cards card4 = new Memory_Game.Cards("santa", Properties.Resources.santa, Properties.Resources.Qmark);
            Cards card5 = new Memory_Game.Cards("heart", Properties.Resources.heart, Properties.Resources.Qmark);
            Cards card6 = new Memory_Game.Cards("fullmark", Properties.Resources._100, Properties.Resources.Qmark);
            Cards card7 = new Memory_Game.Cards("cat", Properties.Resources.cat, Properties.Resources.Qmark);
            Cards card8 = new Memory_Game.Cards("congrats", Properties.Resources.congrats, Properties.Resources.Qmark);
            Cards card9 = new Memory_Game.Cards("crown", Properties.Resources.crown, Properties.Resources.Qmark);
            Cards card10 = new Memory_Game.Cards("high-five", Properties.Resources.high_five, Properties.Resources.Qmark);

            Cards card11 = new Memory_Game.Cards("poo", Properties.Resources.poo, Properties.Resources.Qmark);
            Cards card12 = new Memory_Game.Cards("thump", Properties.Resources.thump_up, Properties.Resources.Qmark);
            Cards card13 = new Memory_Game.Cards("flowers", Properties.Resources.flowers, Properties.Resources.Qmark);
            Cards card14 = new Memory_Game.Cards("santa", Properties.Resources.santa, Properties.Resources.Qmark);
            Cards card15 = new Memory_Game.Cards("heart", Properties.Resources.heart, Properties.Resources.Qmark);
            Cards card16 = new Memory_Game.Cards("fullmark", Properties.Resources._100, Properties.Resources.Qmark);
            Cards card17 = new Memory_Game.Cards("cat", Properties.Resources.cat, Properties.Resources.Qmark);
            Cards card18 = new Memory_Game.Cards("congrats", Properties.Resources.congrats, Properties.Resources.Qmark);
            Cards card19 = new Memory_Game.Cards("crown", Properties.Resources.crown, Properties.Resources.Qmark);
            Cards card20 = new Memory_Game.Cards("high-five", Properties.Resources.high_five, Properties.Resources.Qmark);

            cardListH.Add(card1);
            cardListH.Add(card2);
            cardListH.Add(card3);
            cardListH.Add(card4);
            cardListH.Add(card5);
            cardListH.Add(card6);
            cardListH.Add(card7);
            cardListH.Add(card8);
            cardListH.Add(card9);
            cardListH.Add(card10);
            cardListH.Add(card11);
            cardListH.Add(card12);
            cardListH.Add(card13);
            cardListH.Add(card14);
            cardListH.Add(card15);
            cardListH.Add(card16);
            cardListH.Add(card17);
            cardListH.Add(card18);
            cardListH.Add(card19);
            cardListH.Add(card20);
        }
        
        private void Hardpic ()
        {
            //poo
            if (easyScreen.card1index == 0)
            {
                h4l5.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (easyScreen.card1index == 1)
            {
                h3l1.BackgroundImage = Properties.Resources.Qmark;
            }
            //thump
            else if (easyScreen.card1index == 2)
            {
                h3l5.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (easyScreen.card1index == 3)
            {
                h3l3.BackgroundImage = Properties.Resources.Qmark;
            }
            //flowers
            else if (easyScreen.card1index == 4)
            {
                h2l1.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (easyScreen.card1index == 5)
            {
                h4l3.BackgroundImage = Properties.Resources.Qmark;
            }
            //santa
            else if (easyScreen.card1index == 6)
            {
                h1l2.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (easyScreen.card1index == 7)
            {
                h3l4.BackgroundImage = Properties.Resources.Qmark;
            }
            //heart
            else if (easyScreen.card1index == 8)
            {
                h1l4.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (easyScreen.card1index == 9)
            {
                h3l2.BackgroundImage = Properties.Resources.Qmark;
            }
            //fullmark
            else if (easyScreen.card1index == 10)
            {
                h2l3.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (easyScreen.card1index == 11)
            {
                h2l4.BackgroundImage = Properties.Resources.Qmark;
            }
            //cat
            else if (easyScreen.card1index == 12)
            {
                h1l1.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (easyScreen.card1index == 13)
            {
                h1l5.BackgroundImage = Properties.Resources.Qmark;
            }
            //congrats
            else if (easyScreen.card1index == 14)
            {
                h4l4.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (easyScreen.card1index == 15)
            {
                h4l1.BackgroundImage = Properties.Resources.Qmark;
            }
            //crown
            else if (easyScreen.card1index == 16)
            {
                h2l5.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (easyScreen.card1index == 17)
            {
                h1l3.BackgroundImage = Properties.Resources.Qmark;
            }
            //high-five
            else if (easyScreen.card1index == 18)
            {
                h4l2.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (easyScreen.card1index == 19)
            {
                h2l2.BackgroundImage = Properties.Resources.Qmark;
            }
        }

        private void h4l5_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h4l5.BackgroundImage = cardListH[0].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 0;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 0)
            {
                easyScreen.card2index = 0;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h4l5.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }
                if (easyScreen.cardsLeft == 0)
                {
                    OnEnd();
                   
                }

            }
        }

        private void h2l3_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h2l3.BackgroundImage = cardListH[10].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 10;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 10)
            {
                easyScreen.card2index = 10;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h2l3.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }

            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();
            }
        }

        private void h3l1_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h3l1.BackgroundImage = cardListH[1].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 1;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 1)
            {
                easyScreen.card2index = 1;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h3l1.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }

            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();
            }
        }

        private void h2l4_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h2l4.BackgroundImage = cardListH[11].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 11;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 11)
            {
                easyScreen.card2index = 11;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h2l4.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }

            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();
            }
        }

        private void h3l5_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h3l5.BackgroundImage = cardListH[2].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 2;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 2)
            {
                easyScreen.card2index = 2;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h3l5.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }

            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();
            }
        }

        private void h1l1_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h1l1.BackgroundImage = cardListH[12].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 12;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 12)
            {
                easyScreen.card2index = 12;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h1l1.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }

            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();
            }
        }

        private void h3l3_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h3l3.BackgroundImage = cardListH[3].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 3;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 3)
            {
                easyScreen.card2index = 3;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h3l3.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }

            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();
            }
        }

        private void h1l5_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h1l5.BackgroundImage = cardListH[13].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 13;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 13)
            {
                easyScreen.card2index = 13;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h1l5.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }

            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();
            }
        }

        private void h2l1_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h2l1.BackgroundImage = cardListH[4].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 4;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 4)
            {
                easyScreen.card2index = 4;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h2l1.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }
            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();
            }
        }

        private void h4l4_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h4l4.BackgroundImage = cardListH[14].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 14;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 14)
            {
                easyScreen.card2index = 14;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h4l4.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }

            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();
            }
        }

        private void h4l3_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h4l3.BackgroundImage = cardListH[5].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 5;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 5)
            {
                easyScreen.card2index = 5;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h4l3.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }

            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();
            }
        }

        private void h4l1_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h4l1.BackgroundImage = cardListH[15].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 15;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 15)
            {
                easyScreen.card2index = 15;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h4l1.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }

            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();
            }
        }

        private void h1l2_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h1l2.BackgroundImage = cardListH[6].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 6;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 6)
            {
                easyScreen.card2index = 6;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h1l2.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }
            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();
            }
        }

        private void h2l5_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h2l5.BackgroundImage = cardListH[16].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 16;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 16)
            {
                easyScreen.card2index = 16;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h2l5.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }

            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();
            }
        }

        private void h3l4_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h3l4.BackgroundImage = cardListH[7].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 7;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 7)
            {
                easyScreen.card2index = 7;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h3l4.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }

            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();
            }
        }

        private void h1l3_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h1l3.BackgroundImage = cardListH[17].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 17;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 17)
            {
                easyScreen.card2index = 17;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h1l3.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }

            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();
            }
        }

        private void h1l4_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h1l4.BackgroundImage = cardListH[8].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 8;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 8)
            {
                easyScreen.card2index = 8;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h1l4.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }

            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();
            }
        }

        private void h4l2_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h4l2.BackgroundImage = cardListH[18].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 18;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 18)
            {
                easyScreen.card2index = 18;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h4l2.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }

            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();
            }
        }

        private void h3l2_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h3l2.BackgroundImage = cardListH[9].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 9;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 9)
            {
                easyScreen.card2index = 9;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h3l2.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }
            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();
            }
        }

        private void h2l2_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h2l2.BackgroundImage = cardListH[19].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (easyScreen.cardTurned == 1)
            {
                easyScreen.card1index = 19;
                cleft.Text = easyScreen.cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (easyScreen.cardTurned == 2 && easyScreen.card1index != 19)
            {
                easyScreen.card2index = 19;
                //cardTurned++;
                cleft.Text = easyScreen.cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListH[easyScreen.card1index].value == cardListH[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h2l2.BackgroundImage = Properties.Resources.Qmark;
                    Hardpic();
                    //turn them back and set cards turned over to 0 
                    easyScreen.cardTurned = 0;
                    cleft.Text = easyScreen.cardsLeft + " cards left";
                }
            }
            if (easyScreen.cardsLeft == 0)
            {
                OnEnd();               
            }
        }

        private void timerH_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = f1.playtime.Elapsed;
            timeLabel.Text = "Time: " + ts.Seconds;
            f1.time = timeLabel.Text;
        }
        private void OnEnd()
        {         
            f1.playtime.Stop();
            f1.backPlayer.Stop();
            f1.bPlayer.Stop();

            Form f = this.FindForm();
            f.Controls.Remove(this);

            GameoverScreen los = new GameoverScreen();
            f.Controls.Add(los);

        }
        //private void losG()       
    
    }
}
