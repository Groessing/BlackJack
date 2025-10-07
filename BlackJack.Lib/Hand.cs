using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    public class Hand
    {
        public List<BJCard> HandCards = new List<BJCard>();
        private int _handValue;
        public int HandValue
        {
            get
            {
                return _handValue;
            }
        }

        public void TakeCard(BJCard card)
        {
            if(card != null)
            {
                _handValue = 0;
                HandCards.Add(card);
                foreach (BJCard c in HandCards)
                {
                    _handValue = _handValue + c.BJValue;
                   
                   
                }
            }
            else
            {
                _handValue = 0;
            }
        }
        
        public void SortHand()
        {
            HandCards.Sort();
        }

        public List<BJCard> ClearHand()
        {
            List<BJCard> cards = HandCards;
            HandCards.Clear();
            return cards;
        }
    }
}
