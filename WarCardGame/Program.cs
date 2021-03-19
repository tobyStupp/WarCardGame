using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Card c = new Card(Shape.HEARTS, 14);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
