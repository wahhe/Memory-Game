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
using System.Diagnostics;

namespace Memory_Game
{
    public partial class mediumScreen : UserControl
    {
        private List<Cards> cardListM = new List<Cards>();

        public mediumScreen()
        {
            InitializeComponent();          
            OnStartMed();
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

        private void OnStartMed()
        {
            f1.playtime.Start();
            easyScreen.cardTurned = 0;
            easyScreen.cardsLeft = 14;

            cleft.Text = easyScreen.cardsLeft + " cards left";

            Cards card1 = new Memory_Game.Cards("winkface", Properties.Resources.Wink_Face, Properties.Resources.Qmark);
            Cards card2 = new Memory_Game.Cards("sunglasses", Properties.Resources.Sunglasses, Properties.Resources.Qmark);
            Cards card3 = new Memory_Game.Cards("sick", Properties.Resources.sick, Properties.Resources.Qmark);
            Cards card4 = new Memory_Game.Cards("scary", Properties.Resources.scary, Properties.Resources.Qmark);
            Cards card5 = new Memory_Game.Cards("haha", Properties.Resources.haha, Properties.Resources.Qmark);
            Cards card6 = new Memory_Game.Cards("laughface", Properties.Resources.laugh_Face, Properties.Resources.Qmark);
            Cards card7 = new Memory_Game.Cards("laughcry", Properties.Resources.laughcry, Properties.Resources.Qmark);

            Cards card8 = new Memory_Game.Cards("winkface", Properties.Resources.Wink_Face, Properties.Resources.Qmark);
            Cards card9 = new Memory_Game.Cards("sunglasses", Properties.Resources.Sunglasses, Properties.Resources.Qmark);
            Cards card10 = new Memory_Game.Cards("sick", Properties.Resources.sick, Properties.Resources.Qmark);
            Cards card11 = new Memory_Game.Cards("scary", Properties.Resources.scary, Properties.Resources.Qmark);
            Cards card12 = new Memory_Game.Cards("haha", Properties.Resources.haha, Properties.Resources.Qmark);
            Cards card13 = new Memory_Game.Cards("laughface", Properties.Resources.laugh_Face, Properties.Resources.Qmark);
            Cards card14 = new Memory_Game.Cards("laughcry", Properties.Resources.laughcry, Properties.Resources.Qmark);

            cardListM.Add(card1);
            cardListM.Add(card2);
            cardListM.Add(card3);
            cardListM.Add(card4);
            cardListM.Add(card5);
            cardListM.Add(card6);
            cardListM.Add(card7);
            cardListM.Add(card8);
            cardListM.Add(card9);
            cardListM.Add(card10);
            cardListM.Add(card11);
            cardListM.Add(card12);
            cardListM.Add(card13);
            cardListM.Add(card14);

            //fix the name and properties of the cards in the card list
            //fix the problem in easyscreen
        }

        private void Medpic()
        {
            //winkface
            if (easyScreen.card1index == 0)
            {
                h1l5.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (easyScreen.card1index == 1)
            {
                h3l1.BackgroundImage = Properties.Resources.Qmark;
            }
            //sunglasses
            else if (easyScreen.card1index == 2)
            {
                h2l1.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (easyScreen.card1index == 3)
            {
                h3l4.BackgroundImage = Properties.Resources.Qmark;
            }
            //sick
            else if (easyScreen.card1index == 4)
            {
                h1l3.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (easyScreen.card1index == 5)
            {
                h1l4.BackgroundImage = Properties.Resources.Qmark;
            }
            //scary
            else if (easyScreen.card1index == 6)
            {
                h1l2.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (easyScreen.card1index == 7)
            {
                h2l2.BackgroundImage = Properties.Resources.Qmark;
            }
            //haha
            else if (easyScreen.card1index == 8)
            {
                h2l4.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (easyScreen.card1index == 9)
            {
                h3l2.BackgroundImage = Properties.Resources.Qmark;
            }
            //crying
            else if (easyScreen.card1index == 10)
            {
                h1l1.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (easyScreen.card1index == 11)
            {
                h3l5.BackgroundImage = Properties.Resources.Qmark;
            }
            //laughcry
            else if (easyScreen.card1index == 12)
            {
                h2l3.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (easyScreen.card1index == 13)
            {
                h3l3.BackgroundImage = Properties.Resources.Qmark;
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
            h1l5.BackgroundImage = cardListM[0].front;
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
                if (cardListM[easyScreen.card1index].value == cardListM[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h1l5.BackgroundImage = Properties.Resources.Qmark;
                    Medpic();
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
            h2l2.BackgroundImage = cardListM[7].front;
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
                if (cardListM[easyScreen.card1index].value == cardListM[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h2l2.BackgroundImage = Properties.Resources.Qmark;
                    Medpic();
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
            h3l1.BackgroundImage = cardListM[1].front;
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
                if (cardListM[easyScreen.card1index].value == cardListM[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h3l1.BackgroundImage = Properties.Resources.Qmark;
                    Medpic();
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
            h2l4.BackgroundImage = cardListM[8].front;
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
                if (cardListM[easyScreen.card1index].value == cardListM[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h2l4.BackgroundImage = Properties.Resources.Qmark;
                    Medpic();
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
            h2l1.BackgroundImage = cardListM[2].front;
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
                if (cardListM[easyScreen.card1index].value == cardListM[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h2l1.BackgroundImage = Properties.Resources.Qmark;
                    Medpic();
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
            h3l2.BackgroundImage = cardListM[9].front;
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
                if (cardListM[easyScreen.card1index].value == cardListM[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h3l2.BackgroundImage = Properties.Resources.Qmark;
                    Medpic();
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
            h3l4.BackgroundImage = cardListM[3].front;
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
                if (cardListM[easyScreen.card1index].value == cardListM[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h3l4.BackgroundImage = Properties.Resources.Qmark;
                    Medpic();
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
            h1l1.BackgroundImage = cardListM[10].front;
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
                if (cardListM[easyScreen.card1index].value == cardListM[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h1l1.BackgroundImage = Properties.Resources.Qmark;
                    Medpic();
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
            h1l3.BackgroundImage = cardListM[4].front;
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
                if (cardListM[easyScreen.card1index].value == cardListM[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h1l3.BackgroundImage = Properties.Resources.Qmark;
                    Medpic();
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
            h3l5.BackgroundImage = cardListM[11].front;
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
                if (cardListM[easyScreen.card1index].value == cardListM[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h3l5.BackgroundImage = Properties.Resources.Qmark;
                    Medpic();
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
            h1l4.BackgroundImage = cardListM[5].front;
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
                if (cardListM[easyScreen.card1index].value == cardListM[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h1l4.BackgroundImage = Properties.Resources.Qmark;
                    Medpic();
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

        private void h2l3_Click(object sender, EventArgs e)
        {
            f1.flipPlayer.Stop();
            f1.flipPlayer.Play();
            // update the number of cards turned over
            easyScreen.cardTurned++;
            easyScreen.cardsLeft--;
            //show image
            h2l3.BackgroundImage = cardListM[12].front;
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
                if (cardListM[easyScreen.card1index].value == cardListM[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h2l3.BackgroundImage = Properties.Resources.Qmark;
                    Medpic();
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
            h1l2.BackgroundImage = cardListM[6].front;
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
                if (cardListM[easyScreen.card1index].value == cardListM[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h1l2.BackgroundImage = Properties.Resources.Qmark;
                    Medpic();
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
            h3l3.BackgroundImage = cardListM[13].front;
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
                if (cardListM[easyScreen.card1index].value == cardListM[easyScreen.card2index].value)
                {
                    easyScreen.cardTurned = 0;
                }
                else
                {
                    f1.noMPlayer.Stop();
                    f1.noMPlayer.Play();
                    easyScreen.cardsLeft = easyScreen.cardsLeft + 2;
                    h3l3.BackgroundImage = Properties.Resources.Qmark;
                    Medpic();
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

        private void timerM_Tick(object sender, EventArgs e)
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

    }
}
