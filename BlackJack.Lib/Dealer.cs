using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    public class Dealer : GamePerson
    {
        private static Dealer dealer;
        Deck deck = new Deck();
        public static Dealer CreateDealer(double budget, string name, Hand gamehand)
        {
            if(dealer == null)
            {
                dealer = new Dealer(budget, name, gamehand);
               
            }
            return dealer;
        }

        private Dealer() : base()
        {

        }
        private Dealer(double budget, string name, Hand gamehand) : base(budget, name, gamehand)
        {
            deck.CreateDeck();
            deck.MixDeck();
        }
        public BJCard DrawCard()
        {
            BJCard c = deck.GiveCard();
            return c;
        }

        public override void ReceiveCard(BJCard card)
        {
            GameHand.TakeCard(card);
        }
    }
}
