using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    public class Deck
    {
        public List<BJCard> Cards = new List<BJCard>();
        public Deck()
        {

        }

        public void CreateDeck()
        {

            foreach (CardColor cc in Enum.GetValues(typeof(CardColor)))
            {
                foreach (CardValue cv in Enum.GetValues(typeof(CardValue)))
                {
                    string pn = Convert.ToString(cc) + "_" + Convert.ToString(cv);
                    Cards.Add(new BJCard(cc, cv, pn));
                }
            }
            
            
            //return Cards;
        }

        public void MixDeck()
        {
            Random rand = new Random();
            int c = 0;
            while(c < 1000)
            {
                
                int rnd1 = rand.Next(52);
                int rnd2 = rand.Next(52);

                BJCard a = Cards[rnd1];
                Cards[rnd1] = Cards[rnd2];
                Cards[rnd2] = a;
                c++;
            }
        }

        public void MixDeck(int count)
        {
            int c = 0;
            while (c < count)
            {
                Random rand = new Random();
                int rnd1 = rand.Next(52);
                int rnd2 = rand.Next(52);

                BJCard a = Cards[rnd1];
                Cards[rnd1] = Cards[rnd2];
                Cards[rnd2] = a;

            }
        }

        public BJCard GiveCard()
        {
            if(Cards.Count > 0)
            {
                BJCard c = Cards[0];
                Cards.RemoveAt(0);
                return c;
            }
            else
            {
                return null;
            }
            
               
            
            
            
        }
    }
}
