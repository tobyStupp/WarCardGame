using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCardGame
{
    class Card
    {
        private int value;
        private Shape shape;
        public Card (Shape s, int val)
        {
            this.shape = s;
            if (val < 2 || val > 14)
                throw new Exception("Value of card has to be between 2 and 14");
            this.value = val;
        }
        public Shape GetShape() => shape;
        public int GetValue() => value;
        public string GetStringValue()
        {
            string[] positions = { "JACK", "QUEEN", "KING", "ACE" };
            if (value < 11)
                return value.ToString();
            return positions[value - 11];
        }
        public override string ToString()
        {
            return GetStringValue() + " of " + shape;
        }
        public bool IsPictureCard() => value > 10 && value < 14;
        public bool IsAce() => value == 14;
        public int CompareTo (Card c)
        {
            return value > c.value ? 1 : value < c.value ? -1 : 0;
        }
     

    }
}
