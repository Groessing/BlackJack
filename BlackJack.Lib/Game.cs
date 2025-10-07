using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    public class Game
    {
        private Player player;
        private Dealer dealer;
        Stack stack;

        public Player Player { get => player; set => player = value; }
        public Dealer Dealer { get => dealer; set => dealer = value; }

        public void Start(string name, double budget)
        {
            CreatePlayer(name, budget);
            CreateDealer();
            MixStack();
            for (int i = 0; i < 2; i++)
            {
                DealerGetsCard();
            }

            for (int i = 0; i < 2; i++)
            {
                PlayerGetsCard();
            }

            ShowCardValueStart();
            
        }

        public void MainGame(int choice)
        {
                
            PlayerAction action;

            if (choice == 1)
            {
                action = PlayerAction.HIT;
                ChangePlayerAction(action);
                CheckPlayerAction();
                ShowCardValue();
               //if(player.GameHand.HandValue > 21)
               // {
               //     CheckWinLoss();
               // }
            }
            else if (choice == 2)
            {
                action = PlayerAction.STAND;
                ChangePlayerAction(action);
                CheckPlayerAction();
                ShowCardValue();
               // CheckWinLoss();
            }
            else if (choice == 3)
            {
                action = PlayerAction.SPLIT;
                ChangePlayerAction(action);
            }
            else if (choice == 4)
            {
                action = PlayerAction.INSURE;
                ChangePlayerAction(action);
            }
            else if (choice == 5)
            {
                action = PlayerAction.SURRENDER;
                ChangePlayerAction(action);
            }
            else if (choice == 0)
            {

            }
            else
            {
                Console.WriteLine("Error! The number you entered does not exist within the choices!");
            }
          
        }

        private void CheckPlayerAction()
        {
            if (player.Action == PlayerAction.HIT)
            {
                PlayerGetsCard();
            }

            if (player.Action == PlayerAction.STAND)
            {
                while(dealer.GameHand.HandValue < 17)
                {
                    DealerGetsCard();
                }
                
            }

            if(player.Action == PlayerAction.SPLIT)
            {
                if(player.GameHand.HandCards[0].CValue == player.GameHand.HandCards[1].CValue)
                {
                    player.SplitHand.HandCards.Add(player.GameHand.HandCards[1]);
                    player.GameHand.HandCards.RemoveAt(1);
                }
                else
                {
                    Console.WriteLine("You don't have 2 equal Card Values!");
                }
            }

            if (player.Action == PlayerAction.INSURE)
            {
                if(dealer.GameHand.HandCards[0].CValue == CardValue.Ace)
                {
                    player.Budget = player.Budget / 2;
                    if(dealer.GameHand.HandValue == 21)
                    {
                        player.Budget = player.Budget * 2;
                    }
                }
                else
                {
                    Console.WriteLine("You only can insure, when Dealer has an Ace as first Card!");
                }
            }

            if (player.Action == PlayerAction.SURRENDER)
            {
                player.Budget = player.Budget / 2;
                Console.WriteLine("Dealer won");
            }
        }

        private void ChangePlayerAction(PlayerAction action)
        {
            player.Action = action;
        }
        private void CreatePlayer(string name, double budget)
        {
            Hand splitHand = new Hand();
            Hand gamehand = new Hand();
            player = new Player(splitHand, PlayerAction.HIT, budget, name, gamehand);
        }

        private void CreateDealer()
        {
            Hand splitHand = new Hand();
            Hand gamehand = new Hand();
            dealer = Dealer.CreateDealer(1000, "Danny", gamehand);
        }

        private void MixStack()
        {
            stack = new Stack(5);
            stack.MixStack();
        }

        private void DealerGetsCard()
        {
            BJCard card = dealer.DrawCard(); 
            dealer.ReceiveCard(card);
        }

        private void PlayerGetsCard()
        {
            BJCard card = dealer.DrawCard();
            player.ReceiveCard(card);
        }
       
        private void ShowCardValueStart()
        {
            int playerValue = player.GameHand.HandValue;
            int dealerValue = dealer.GameHand.HandValue;
            Console.WriteLine("Player: " + player.GameHand.HandCards[0].PicName + " " + player.GameHand.HandCards[1].PicName + playerValue);
            Console.WriteLine("Dealer: " + " (" + dealer.GameHand.HandCards[0].PicName + ")" + dealer.GameHand.HandCards[1].PicName + dealerValue);
            Console.WriteLine();
        }  //Just to test if it shows correctly

        private void ShowCardValue()
        {
            int playerValue = player.GameHand.HandValue;
            int dealerValue = dealer.GameHand.HandValue;
            foreach (BJCard card in player.GameHand.HandCards)
            {
                Console.Write(card.PicName + " ");

            }
            Console.Write(playerValue);

            Console.WriteLine();

            foreach (BJCard card in dealer.GameHand.HandCards)
            {
                if(card == dealer.GameHand.HandCards[0] && player.Action == PlayerAction.HIT) //You only can see one card, in brackets it's the card you don't know as player
                {
                    Console.Write($"({card.PicName}) ");
                }
                else
                {
                    Console.Write(card.PicName + " ");
                }
                

            }
            Console.Write(dealerValue);
            Console.WriteLine();
        }

        public string CheckWinLoss()
        {
            string result = "";
            //BlackJack for Player
            if(player.GameHand.HandValue == 21 && player.GameHand.HandCards.Count == 2 && dealer.GameHand.HandValue != 21)
            {
                Console.WriteLine($"BlackJack for {player.Name}!");
                result = $"BlackJack for {player.Name}!";
            }

            //BlackJack for Player
            if (dealer.GameHand.HandValue == 21 && dealer.GameHand.HandCards.Count == 2 && player.GameHand.HandValue != 21)
            {
                Console.WriteLine("BlackJack for Dealer!");
                result = "BlackJack for Dealer!";
            }


            //Player HandValue > 21 and Dealer HandValue <= 21
            if (player.GameHand.HandValue > 21) //&& dealer.GameHand.HandValue < 21
            {
                Console.WriteLine("Dealer wins!");
                result = "Dealer wins!";
            }

            //Dealer HandValue > 21 and Player HandValue <= 21
            if (dealer.GameHand.HandValue > 21) // && player.GameHand.HandValue < 21
            {
                Console.WriteLine($"{player.Name} wins!");
                result = $"{player.Name} wins!";
            }


            //If Player HandValue = Dealer HandValue
            if (player.GameHand.HandValue == dealer.GameHand.HandValue)
            {
                Console.WriteLine("Push!");
                result = "Push!";
            }


            //If the Player HandValue is close to 21
            if(player.GameHand.HandValue > dealer.GameHand.HandValue && player.GameHand.HandValue <= 21)
            {
                Console.WriteLine($"{player.Name} wins!");
                result = $"{player.Name} wins!";
            }

            //If the Dealer HandValue is close to 21
            if (dealer.GameHand.HandValue > player.GameHand.HandValue && dealer.GameHand.HandValue <= 21)
            {
                Console.WriteLine("Dealer wins!");
                result = "Dealer wins";
            }

            return result;
        }

        
        

        
    }
}
