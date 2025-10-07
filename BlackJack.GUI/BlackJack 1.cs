using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlackJack.Lib;
namespace BlackJack.GUI
{
    public partial class Form1 : Form
    {
        int playerNumber;
        int countCards = 0;
        Deck d = new Deck();
        Stack s = new Stack(5);
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnCreateDeck_Click(object sender, EventArgs e)
        {
            lblPlayer1.BackColor = Color.Green;
            lblPlayer2.BackColor = Color.Green;
            lblPlayer3.BackColor = Color.Green;
            lblPlayer4.BackColor = Color.Green;


            //d.CreateDeck();
            //d.MixDeck();
            //string cardDeck = d.Cards[0].PicName;

            s.MixStack();
            string cardDeck = s.Cards[0].PicName;



            picDeck.Image = (Image)Properties.Resources.ResourceManager.GetObject(cardDeck);
            picPlayer1.Image = (Image)Properties.Resources.ResourceManager.GetObject("CardSkin");
            picPlayer2.Image = (Image)Properties.Resources.ResourceManager.GetObject("CardSkin");
            picPlayer3.Image = (Image)Properties.Resources.ResourceManager.GetObject("CardSkin");
            picPlayer4.Image = (Image)Properties.Resources.ResourceManager.GetObject("CardSkin");
            playerNumber = 1;
            //countCards = 52;
            countCards = 260;
            tbxCardsCount.Text = "" + countCards;
        }

        private void picDeck_Click(object sender, EventArgs e)
        {
            try
            {
                //Card card = d.GiveCard();
                Card card = s.GiveCard();

                if (playerNumber == 1)
                {
                    if(countCards > 0)
                    {
                        picPlayer1.Image = (Image)Properties.Resources.ResourceManager.GetObject(card.PicName);
                        lblPlayer4.BackColor = Color.Green;
                        lblPlayer1.BackColor = Color.Red;
                        playerNumber++;
                    }
                    else
                    {
                        MessageBox.Show("Es sind keine Karten mehr vorhanden!");
                    }
                    
                }
                else if (playerNumber == 2)
                {
                    if(countCards > 0)
                    {
                        picPlayer2.Image = (Image)Properties.Resources.ResourceManager.GetObject(card.PicName);
                        lblPlayer1.BackColor = Color.Green;
                        lblPlayer2.BackColor = Color.Red;
                        playerNumber++;
                    }
                   
                    else
                    {
                        MessageBox.Show("Es sind keine Karten mehr vorhanden!");
                    }
                }
                else if (playerNumber == 3)
                {
                    if(countCards > 0)
                    {
                        picPlayer3.Image = (Image)Properties.Resources.ResourceManager.GetObject(card.PicName);
                        lblPlayer2.BackColor = Color.Green;
                        lblPlayer3.BackColor = Color.Red;
                        playerNumber++;
                    }
                    
                    else
                    {
                        MessageBox.Show("Es sind keine Karten mehr vorhanden!");
                    }
                }
                else if (playerNumber == 4)
                {
                    if(countCards > 0)
                    {
                        picPlayer4.Image = (Image)Properties.Resources.ResourceManager.GetObject(card.PicName);
                        lblPlayer3.BackColor = Color.Green;
                        lblPlayer4.BackColor = Color.Red;
                        playerNumber = 1;

                    }
                    
                    else
                    {
                        MessageBox.Show("Es sind keine Karten mehr vorhanden!");
                    }
                }
                if (countCards > 1)
                {
                    //string cardDeck = d.Cards[0].PicName;
                    string cardDeck = s.Cards[0].PicName;


                    picDeck.Image = (Image)Properties.Resources.ResourceManager.GetObject(cardDeck);
                    countCards--;
                    tbxCardsCount.Text = "" + countCards;
                }
                else if (countCards == 1)
                {
                    picDeck.Image = (Image)Properties.Resources.ResourceManager.GetObject("CardSkin");
                    countCards--;
                    tbxCardsCount.Text = "" + countCards;
                }
               
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Es sind keine Karten mehr vorhanden!");
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Es sind keine Karten mehr vorhanden!");
            }
            catch
            {
                MessageBox.Show("Es sind keine Karten mehr vorhanden!");
            }  


        }
    }
}
