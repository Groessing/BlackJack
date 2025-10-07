using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    public class Player : GamePerson
    {
        public Hand SplitHand;
        public PlayerAction Action;

        public Player() : base()
        {

        }
        public Player(Hand splithand, PlayerAction action, double budget, string name, Hand gamehand) : base(budget, name, gamehand)
        {
            SplitHand = splithand;
            Action = action;
        }

        public override void ReceiveCard(BJCard card)
        {
          //  GameHand.HandCards.Add(card);
            GameHand.TakeCard(card);
        }
    }
}
