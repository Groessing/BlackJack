using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Lib
{
    public abstract class Card
    {
        public CardColor CColor;
        public CardValue CValue;
        public string PicName;

        public Card(CardColor cardColor, CardValue cardValue, string picName)
        {
            CColor = cardColor;
            CValue = cardValue;
            PicName = picName;
        }


    public Card(CardColor cardColor, CardValue cardValue)
    {
        CColor = cardColor;
        CValue = cardValue;

    }

    public abstract string ToString();
        //{
        //    return $"{CColor};{CValue}";
        //}

}
}
