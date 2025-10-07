using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    public class BJCard : Card, IComparable
    {
        public int BJValue;
        private Dictionary<CardValue, int> _BjDic = new Dictionary<CardValue, int>();
        
        
        public BJCard(CardColor cardColor, CardValue cardValue, string picName) : base(cardColor, cardValue, picName)
        {
            InitDic();  
            BJValue = _BjDic[cardValue];
        }

        public BJCard(CardColor cardColor, CardValue cardValue) : base(cardColor, cardValue)
        {
            InitDic();
            BJValue = _BjDic[cardValue];
        }
        private void InitDic()
        {
            _BjDic.Add(CardValue.Ace, 1);
            _BjDic.Add(CardValue.Two, 2);
            _BjDic.Add(CardValue.Three, 3);
            _BjDic.Add(CardValue.Four, 4);
            _BjDic.Add(CardValue.Five, 5);
            _BjDic.Add(CardValue.Six, 6);
            _BjDic.Add(CardValue.Seven, 7);
            _BjDic.Add(CardValue.Eight, 8);
            _BjDic.Add(CardValue.Nine, 9);
            _BjDic.Add(CardValue.Ten, 10);
            _BjDic.Add(CardValue.King, 10);
            _BjDic.Add(CardValue.Queen, 10);
            _BjDic.Add(CardValue.Jack, 10);
           
        }

        public int CompareTo(object obj)
        {
           // throw new NotImplementedException();
            //BJCard other = (BJCard)obj;
            //return this.CColorCompareTo(other.CColor);

            //BJCard other = obj as BJCard;
            //return this.CColor.CompareTo(other.CColor);

            BJCard other = obj as BJCard;
            int colorComparison = this.CColor.CompareTo(other.CColor);

            if(colorComparison == 0)
            {
                return this.CValue.CompareTo(other.CValue);
            }
            else
            {
                return CColor.CompareTo(other.CColor);

            }
        }

        public override string ToString()
        {
            return $"{CColor};{CValue};{BJValue}";
        }
    }
}
