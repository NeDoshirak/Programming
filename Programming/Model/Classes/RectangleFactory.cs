using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class RectangleFactory
    {
        static Random rnd = new Random();

        static public Rectangle Randomize()
        {
            return new Rectangle(rnd.Next(1, 100), rnd.Next(1, 100), "Green", rnd.Next(1, 406), rnd.Next(1, 363));
        }
    }
}
