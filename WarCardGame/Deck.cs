using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCardGame
{
    class Deck
    {
        private List<Card> cards;
        public Deck ()
        {
            cards = new List<Card>();
            for (int i = 2; i < 15; i++)
            {
                for (Shape s = Shape.SPADES; s < = Shape.CLUBS; s++)
                    cards.Add(new Card(s, i));
            }
            Shuffle();
        }
        public void Shuffle ()
        {
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                Card c = cards[rnd.Next(cards.Count)];
                cards.Remove(c);
                cards.Add(c);
            }
        }
        public Card Deal ()
        {
            Card c = cards[0];
            cards.Remove(c);
            return c;
        }
    }
}
