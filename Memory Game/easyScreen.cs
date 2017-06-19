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

namespace Memory_Game
{
    public partial class easyScreen : UserControl
    {
        
        //list to hold cards
        private List<Cards> cardListE = new List<Cards>();     
        public static int cardsLeft, card1index, card2index, cardTurned, time;

        private void h1l1_Click(object sender, EventArgs e)
        {
            // update the number of cards turned over
            cardTurned++;
            cardsLeft--;
            //show image
            h1l1.BackgroundImage = cardListE[0].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (cardTurned == 1)
            {                
                card1index = 0;
                cleft.Text = cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (cardTurned == 2)
            {
                card2index = 1;
                //cardTurned++;
                cleft.Text = cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListE[card1index].value == cardListE[card2index].value)
                {                  
                    cardTurned = 0;
                }
                else
                {
                    cardsLeft = cardsLeft + 2;
                    h1l1.BackgroundImage = Properties.Resources.Qmark;
                    EasyCpics();
                    //turn them back and set cards turned over to 0 
                    cardTurned = 0;
                    cleft.Text = cardsLeft + " cards left";
                }

            }
        }

        private void h2l2_Click(object sender, EventArgs e)
        {
            //show image
            h2l2.BackgroundImage = cardListE[6].front;
            Refresh();
            cardsLeft--;
            Thread.Sleep(500);
            // update the number of cards turned over
            cardTurned++;
            
            //if cards turned = 1
            if (cardTurned == 1)
            {
                card1index = 1;
                cleft.Text = cardsLeft + "cards left";
            }
            // if there are 2 cards turned over
            if (cardTurned == 2)
            {
                card2index = 0;
                //cardTurned++;
                cleft.Text = cardsLeft + "cards left";
                // if the two cards are the same
                if (cardListE[card1index].value == cardListE[card2index].value)
                {
                    
                    cardTurned = 0;
                }
                else
                {
                    cardsLeft = cardsLeft + 2;
                    h2l2.BackgroundImage = Properties.Resources.Qmark;
                    EasyCpics();
                    cardTurned = 0;
                    cleft.Text = cardsLeft + " cards left";
                }
            }
        }

        private void h4l1_Click(object sender, EventArgs e)
        {
            // update the number of cards turned over
            cardTurned++;
            cardsLeft--;
            //show image
            h4l1.BackgroundImage = cardListE[7].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (cardTurned == 1)
            {
                card1index = 2;
                cleft.Text = cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (cardTurned == 2)
            {
                card2index = 3;
                //cardTurned++;
                cleft.Text = cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListE[card1index].value == cardListE[card2index].value)
                {
                    cardTurned = 0;
                }
                else
                {
                    cardsLeft = cardsLeft + 2;
                    h4l1.BackgroundImage = Properties.Resources.Qmark;
                    EasyCpics();
                    //turn them back and set cards turned over to 0 
                    cardTurned = 0;
                    cleft.Text = cardsLeft + " cards left";
                }
            }
         }

        private void h1l3_Click(object sender, EventArgs e)
        {
            // update the number of cards turned over
            cardTurned++;
            cardsLeft--;
            //show image
            h1l3.BackgroundImage = cardListE[1].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (cardTurned == 1)
            {
                card1index = 3;
                cleft.Text = cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (cardTurned == 2)
            {
                card2index = 2;
                //cardTurned++;
                cleft.Text = cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListE[card1index].value == cardListE[card2index].value)
                {
                    
                    cardTurned = 0;
                }
                else
                {
                    cardsLeft = cardsLeft + 2;
                    h1l3.BackgroundImage = Properties.Resources.Qmark;
                    EasyCpics();
                    //turn them back and set cards turned over to 0 
                    cardTurned = 0;
                    cleft.Text = cardsLeft + " cards left";
                }
            }
        }

        private void h2l1_Click(object sender, EventArgs e)
        {
            // update the number of cards turned over
            cardTurned++;
            cardsLeft--;
            //show image
            h2l1.BackgroundImage = cardListE[2].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (cardTurned == 1)
            {
                card1index = 4;
                cleft.Text = cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (cardTurned == 2)
            {
                card2index = 5;
                //cardTurned++;
                cleft.Text = cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListE[card1index].value == cardListE[card2index].value)
                {
                    cardTurned = 0;
                }
                else
                {
                    cardsLeft = cardsLeft + 2;
                    h2l1.BackgroundImage = Properties.Resources.Qmark;
                    EasyCpics();
                    //turn them back and set cards turned over to 0 
                    cardTurned = 0;
                    cleft.Text = cardsLeft + " cards left";
                }
            }
        }

        private void h3l3_Click(object sender, EventArgs e)
        {
            // update the number of cards turned over
            cardTurned++;
            cardsLeft--;
            //show image
            h3l3.BackgroundImage = cardListE[8].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (cardTurned == 1)
            {
                card1index = 5;
                cleft.Text = cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (cardTurned == 2)
            {
                card2index = 4;
                //cardTurned++;
                cleft.Text = cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListE[card1index].value == cardListE[card2index].value)
                {
                    
                    cardTurned = 0;
                }
                else
                {
                    //cardsLeft += 2;
                    cardsLeft = cardsLeft + 2;
                    h3l3.BackgroundImage = Properties.Resources.Qmark;
                    EasyCpics();
                    //turn them back and set cards turned over to 0 
                    cardTurned = 0;
                    cleft.Text = cardsLeft + " cards left";
                }
            }
        }

        private void h1l2_Click(object sender, EventArgs e)
        {
            // update the number of cards turned over
            cardTurned++;
            cardsLeft--;
            //show image
            h1l2.BackgroundImage = cardListE[3].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (cardTurned == 1)
            {
                card1index = 6;
                cleft.Text = cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (cardTurned == 2)
            {
                card2index = 7;
                //cardTurned++;
                cleft.Text = cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListE[card1index].value == cardListE[card2index].value)
                {
                    
                    cardTurned = 0;
                }
                else
                {
                    //cardsLeft += 2;
                    cardsLeft = cardsLeft + 2;
                    h1l2.BackgroundImage = Properties.Resources.Qmark;
                    EasyCpics();
                    //turn them back and set cards turned over to 0 
                    cardTurned = 0;
                    cleft.Text = cardsLeft + " cards left";
                }
            }
        }

        private void h4l3_Click(object sender, EventArgs e)
        {
            // update the number of cards turned over
            cardTurned++;
            cardsLeft--;
            //show image
            h4l3.BackgroundImage = cardListE[9].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (cardTurned == 1)
            {
                card1index = 7;
                cleft.Text = cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (cardTurned == 2)
            {
                card2index = 6;
                //cardTurned++;
                cleft.Text = cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListE[card1index].value == cardListE[card2index].value)
                {
                    
                    cardTurned = 0;
                }
                else
                {
                    //cardsLeft += 2;
                    cardsLeft = cardsLeft + 2;
                    h4l3.BackgroundImage = Properties.Resources.Qmark;
                    EasyCpics();
                    //turn them back and set cards turned over to 0 
                    cardTurned = 0;
                    cleft.Text = cardsLeft + " cards left";
                }
            }
        }

        private void h4l2_Click(object sender, EventArgs e)
        {
            // update the number of cards turned over
            cardTurned++;
            cardsLeft--;
            //show image
            h4l2.BackgroundImage = cardListE[4].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (cardTurned == 1)
            {
                card1index = 8;
                cleft.Text = cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (cardTurned == 2)
            {
                card2index = 9;
                //cardTurned++;
                cleft.Text = cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListE[card1index].value == cardListE[card2index].value)
                {
                    
                    cardTurned = 0;
                }
                else
                {
                    //cardsLeft += 2;
                    cardsLeft = cardsLeft + 2;
                    h4l2.BackgroundImage = Properties.Resources.Qmark;
                    EasyCpics();
                    //turn them back and set cards turned over to 0 
                    cardTurned = 0;
                    cleft.Text = cardsLeft + " cards left";
                }
            }
        }

        private void h3l1_Click(object sender, EventArgs e)
        {
            // update the number of cards turned over
            cardTurned++;
            cardsLeft--;
            //show image
            h3l1.BackgroundImage = cardListE[5].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (cardTurned == 1)
            {
                card1index = 10;
                cleft.Text = cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (cardTurned == 2)
            {
                card2index = 11;
                //cardTurned++;
                cleft.Text = cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListE[card1index].value == cardListE[card2index].value)
                {
                    
                    cardTurned = 0;
                }
                else
                {
                    //cardsLeft += 2;
                    cardsLeft = cardsLeft + 2;
                    h3l1.BackgroundImage = Properties.Resources.Qmark;
                    EasyCpics();
                    //turn them back and set cards turned over to 0 
                    cardTurned = 0;
                    cleft.Text = cardsLeft + " cards left";
                }
            }
        }

        private void h2l3_Click(object sender, EventArgs e)
        {
            // update the number of cards turned over
            cardTurned++;
            cardsLeft--;
            //show image
            h2l3.BackgroundImage = cardListE[11].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (cardTurned == 1)
            {
                card1index = 11;
                cleft.Text = cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (cardTurned == 2)
            {
                card2index = 10;
                //cardTurned++;
                cleft.Text = cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListE[card1index].value == cardListE[card2index].value)
                {
                    
                    cardTurned = 0;
                }
                else
                {
                    //cardsLeft += 2;
                    cardsLeft = cardsLeft + 2;
                    h2l3.BackgroundImage = Properties.Resources.Qmark;
                    EasyCpics();
                    //turn them back and set cards turned over to 0 
                    cardTurned = 0;
                    cleft.Text = cardsLeft + " cards left";
                }
            }
        }

        private void h3l2_Click(object sender, EventArgs e)
        {
            // update the number of cards turned over
            cardTurned++;
            cardsLeft--;
            //show image
            h3l2.BackgroundImage = cardListE[10].front;
            Refresh();
            Thread.Sleep(500);
            //if cards turned = 1
            if (cardTurned == 1)
            {
                card1index = 9;
                cleft.Text = cardsLeft + " cards left";
            }
            // if there are 2 cards turned over
            if (cardTurned == 2)
            {
                card2index = 8;
                //cardTurned++;
                cleft.Text = cardsLeft + " cards left";
                // if the two cards are the same
                if (cardListE[card1index].value == cardListE[card2index].value)
                {
                    
                    cardTurned = 0;
                }
                else
                {
                    //cardsLeft += 2;
                    cardsLeft = cardsLeft + 2;
                    h3l2.BackgroundImage = Properties.Resources.Qmark;
                    EasyCpics();
                    //turn them back and set cards turned over to 0 
                    cardTurned = 0;
                    cleft.Text = cardsLeft + " cards left";
                }
            }
        }

        public easyScreen()
        {
            InitializeComponent();
            OnStartEasy();
        }     
        //add 12 cards, each of them have a value in it
        public void OnStartEasy()
        {
            cardTurned = 0;
            cardsLeft = 12;

            cleft.Text = cardsLeft + " cards left";

            Cards card1 = new Memory_Game.Cards("dog", Properties.Resources.dog, Properties.Resources.Qmark);
            Cards card2 = new Memory_Game.Cards("fullmark", Properties.Resources._100, Properties.Resources.Qmark);
            Cards card3 = new Memory_Game.Cards("cat", Properties.Resources.cat, Properties.Resources.Qmark);
            Cards card4 = new Memory_Game.Cards("congrats", Properties.Resources.congrats, Properties.Resources.Qmark);
            Cards card5 = new Memory_Game.Cards("crown", Properties.Resources.crown, Properties.Resources.Qmark);
            Cards card6 = new Memory_Game.Cards("crying", Properties.Resources.Crying, Properties.Resources.Qmark);

            Cards card7 = new Memory_Game.Cards("dog", Properties.Resources.dog, Properties.Resources.Qmark);
            Cards card8 = new Memory_Game.Cards("fullmark", Properties.Resources._100, Properties.Resources.Qmark);
            Cards card9 = new Memory_Game.Cards("cat", Properties.Resources.cat, Properties.Resources.Qmark);
            Cards card10 = new Memory_Game.Cards("congrats", Properties.Resources.congrats, Properties.Resources.Qmark);
            Cards card11 = new Memory_Game.Cards("crown", Properties.Resources.crown, Properties.Resources.Qmark);
            Cards card12 = new Memory_Game.Cards("crying", Properties.Resources.Crying, Properties.Resources.Qmark);

            cardListE.Add(card1);
            cardListE.Add(card2);
            cardListE.Add(card3);
            cardListE.Add(card4);
            cardListE.Add(card5);
            cardListE.Add(card6);
            cardListE.Add(card7);
            cardListE.Add(card8);
            cardListE.Add(card9);
            cardListE.Add(card10);
            cardListE.Add(card11);
            cardListE.Add(card12);
            
        }
        //flip cards method
        private void EasyCpics()
        {
            //dog
            if (card1index == 0   )
            {
                h1l1.BackgroundImage = Properties.Resources.Qmark;   
            }
            else if (card1index == 1)
            {
                h2l2.BackgroundImage = Properties.Resources.Qmark;
            }
            //fullmark
            else if (card1index == 2)
            {
                h4l1.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (card1index == 3)
            {
                h1l3.BackgroundImage = Properties.Resources.Qmark;
            }
            //cat
            else if (card1index == 4)
            {
                h2l1.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (card1index == 5)
            {
                h3l3.BackgroundImage = Properties.Resources.Qmark;
            }
            //cograts
            else if (card1index == 6)
            {
                h1l2.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (card1index == 7)
            {
                h4l3.BackgroundImage = Properties.Resources.Qmark;
            }
            //crown
            else if (card1index == 8)
            {
                h4l2.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (card1index == 9)
            {
                h3l2.BackgroundImage = Properties.Resources.Qmark;
            }
            //crying
            else if (card1index == 10)
            {
                h3l1.BackgroundImage = Properties.Resources.Qmark;
            }
            else if (card1index == 11)
            {
                h2l3.BackgroundImage = Properties.Resources.Qmark;
            }
        }
        
        
    }
}

