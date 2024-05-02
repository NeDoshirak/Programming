using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class CollisionManager
    {
        static public bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            double differenceX = Math.Abs(rectangle1.Center.X - rectangle2.Center.X);
            double halfLatitude = Math.Abs(rectangle1.Width + rectangle2.Width) / 2;
            double differenceY = Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y);
            double halfLength = Math.Abs(rectangle1.Height + rectangle2.Height) / 2;
            return differenceX < halfLatitude && differenceY < halfLength;
        }
        static public bool IsCollision(Panel panel1, Panel panel2)
        {
            double differenceX = Math.Abs(panel1.Location.X - panel2.Location.X);
            double halfLatitude = Math.Abs(panel1.Width + panel2.Width) / 2;
            double differenceY = Math.Abs(panel1.Location.Y - panel2.Location.Y);
            double halfLength = Math.Abs(panel1.Height + panel2.Height) / 2;
            return differenceX < halfLatitude && differenceY < halfLength;
        }


        static public bool IsCollision(Ring ring1, Ring ring2)
        {
            double hypotenuse = Math.Sqrt(Math.Pow(Math.Abs(ring1.Center.X - ring2.Center.X), 2) + Math.Pow(Math.Abs(ring1.Center.Y - ring2.Center.Y), 2));
            double sumOfExternalRadii = ring1.RadiusExternal + ring2.RadiusExternal;
            return hypotenuse < sumOfExternalRadii;
        }
    }
}
