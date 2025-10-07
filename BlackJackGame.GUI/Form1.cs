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
namespace BlackJackGame.GUI
{
    public partial class Form1 : Form
    {
        Game g = new Game();
        bool visibleColor = false;

        public Form1(bool visiblePlayerHand, bool visiblePlayerHandColor, string name, double budget, double bet)
        {
            InitializeComponent();
            BackColor = Color.Green;

            tbxPlayerValue.Visible = visiblePlayerHand;
            lblPlayerValue.Visible = visiblePlayerHand;
            visibleColor = visiblePlayerHandColor;

            lblPlayer.Text = name;
            lblPlayerValue.Text = name + "'s Value";
          
            picDealerCard3.Visible = false;
            picDealerCard4.Visible = false;
            picDealerCard5.Visible = false;
            picDealerCard6.Visible = false;
            picDealerCard7.Visible = false;


            picPlayerCard3.Visible = false;
            picPlayerCard4.Visible = false;
            picPlayerCard5.Visible = false;
            picPlayerCard6.Visible = false;
            picPlayerCard7.Visible = false;


            g.Start(name, budget);


            picPlayerCard1.Image = (Image)Properties.Resources.ResourceManager.GetObject(g.Player.GameHand.HandCards[0].PicName);
            picPlayerCard2.Image = (Image)Properties.Resources.ResourceManager.GetObject(g.Player.GameHand.HandCards[1].PicName);

            picDealerCard2.Image = (Image)Properties.Resources.ResourceManager.GetObject(g.Dealer.GameHand.HandCards[1].PicName);


            tbxPlayerValue.Text = "" + g.Player.GameHand.HandValue;


            if (visibleColor == true)
            {
                if (g.Player.GameHand.HandValue > 16 && g.Player.GameHand.HandValue < 21)
                {
                    tbxPlayerValue.ForeColor = Color.Green;
                }
                else
                {
                    tbxPlayerValue.ForeColor = Color.Red;
                }
            }

            if (g.Dealer.GameHand.HandValue == 21 || g.Player.GameHand.HandValue == 21)
            {
                string winLoss = g.CheckWinLoss();
                MessageBox.Show(winLoss, "BlackJack");
            }

        }


        private void btnHIT_Click(object sender, EventArgs e)
        {
            g.MainGame(1);

            if (picPlayerCard3.Image == null)
            {
                picPlayerCard3.Image = (Image)Properties.Resources.ResourceManager.GetObject(g.Player.GameHand.HandCards[2].PicName);
                picPlayerCard3.Visible = true;
            }
            else
            {
                if (picPlayerCard4.Image == null)
                {
                    picPlayerCard4.Image = (Image)Properties.Resources.ResourceManager.GetObject(g.Player.GameHand.HandCards[3].PicName);
                    picPlayerCard4.Visible = true;
                }
                else
                {
                    if (picPlayerCard5.Image == null)
                    {
                        picPlayerCard5.Image = (Image)Properties.Resources.ResourceManager.GetObject(g.Player.GameHand.HandCards[4].PicName);
                        picPlayerCard5.Visible = true;
                    }
                    else
                    {
                        if (picPlayerCard6.Image == null)
                        {
                            picPlayerCard6.Image = (Image)Properties.Resources.ResourceManager.GetObject(g.Player.GameHand.HandCards[5].PicName);
                            picPlayerCard6.Visible = true;
                        }
                        else
                        {
                            if (picPlayerCard7.Image == null)
                            {
                                picPlayerCard7.Image = (Image)Properties.Resources.ResourceManager.GetObject(g.Player.GameHand.HandCards[6].PicName);
                                picPlayerCard7.Visible = true;
                            }
                        }
                    }
                }
            }
            tbxPlayerValue.Text = "" + g.Player.GameHand.HandValue;
            if (visibleColor == true)
            {
                if (g.Player.GameHand.HandValue > 16 && g.Player.GameHand.HandValue < 21)
                {
                    tbxPlayerValue.ForeColor = Color.Green;
                }
                else
                {
                    tbxPlayerValue.ForeColor = Color.Red;
                }
            }




            if (g.Player.GameHand.HandValue >= 21)
            {
                picDealerCard1.Image = (Image)Properties.Resources.ResourceManager.GetObject(g.Dealer.GameHand.HandCards[0].PicName);
                string winLoss = g.CheckWinLoss();
                MessageBox.Show(winLoss);

            }
        }


        private void btnSTAND_Click(object sender, EventArgs e)
        {
            g.MainGame(2);
            picDealerCard1.Image = (Image)Properties.Resources.ResourceManager.GetObject(g.Dealer.GameHand.HandCards[0].PicName);


            for (int i = 2; i < g.Dealer.GameHand.HandCards.Count; i++)
            {
                if (i == 2)
                {
                    picDealerCard3.Image = (Image)Properties.Resources.ResourceManager.GetObject(g.Dealer.GameHand.HandCards[2].PicName);
                    picDealerCard3.Visible = true;
                }
                if (i == 3)
                {
                    picDealerCard4.Image = (Image)Properties.Resources.ResourceManager.GetObject(g.Dealer.GameHand.HandCards[3].PicName);
                    picDealerCard4.Visible = true;
                }

                if (i == 4)
                {
                    picDealerCard5.Image = (Image)Properties.Resources.ResourceManager.GetObject(g.Dealer.GameHand.HandCards[4].PicName);
                    picDealerCard5.Visible = true;
                }

                if (i == 5)
                {
                    picDealerCard6.Image = (Image)Properties.Resources.ResourceManager.GetObject(g.Dealer.GameHand.HandCards[5].PicName);
                    picDealerCard6.Visible = true;
                }

                if (i == 6)
                {
                    picDealerCard7.Image = (Image)Properties.Resources.ResourceManager.GetObject(g.Dealer.GameHand.HandCards[6].PicName);
                    picDealerCard7.Visible = true;
                }
            }

            string winLoss = g.CheckWinLoss();
            MessageBox.Show(winLoss, "BlackJack");
            btnHIT.Enabled = false;
            btnSTAND.Enabled = false;

        }

        
    }
}
