using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    public abstract class GamePerson
    {
        public double Budget;
        public string Name;
        public Hand GameHand;

        public GamePerson()
        {

        }
        public GamePerson(double budget, string name, Hand gamehand)
        {
            Budget = budget;
            Name = name;
            GameHand = gamehand;
        }
        public abstract void ReceiveCard(BJCard card);
        
    }
}
