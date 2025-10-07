using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    public class Stack
    {
        public List<BJCard> Cards = new List<BJCard>();

        public Stack(int countDeck)
        {
            Deck d = new Deck();
            d.CreateDeck();
            for (int i = 0; i < countDeck; i++)
            {
                for(int j = 0; j < d.Cards.Count; j++)
                {
                    Cards.Add(d.Cards[j]);
                }
            }
        }
        public void MixStack()
        {
            Random rand = new Random();
            int c = 0;
            while (c < 5000)
            {

                int rnd1 = rand.Next(260);
                int rnd2 = rand.Next(260);

                BJCard a = Cards[rnd1];
                Cards[rnd1] = Cards[rnd2];
                Cards[rnd2] = a;
                c++;
            }
        }

        public void MixStack(int count)
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
            BJCard card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }
    }
}
