using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1 = 0;
            int y1 = h;
            int x2 = 3 * h;
            int y2 = 0;

            int x3 = h;
            int y3 = h * 4;
            int x4 = h * 2;
            int y4 = h;

            if ((x > x1 && x < x2 && y < y1 && y > y2) || (x > x3 && x < x4 && y < y3
                && y > y4) || (x > h && x < h * 2 && y < h * 4 && y >= h))
            {
                Console.WriteLine("inside");
            }
            else if (((x == x1 || x == x2) && (y <= y1 && y >= y2)) || ((x == x3 || x == x4) && (y >= 0 && y <= y3 || y == y4)) ||
                ((x >= x1 && x <= x2) && (y == y1 || y == y2)) || ((x >= x3 && x <= x4) && (y == y3 || y == y4)))
            {
                Console.WriteLine("border");
            }
            else if ((x < x1 || x > x2 || y > y1 || y < y2) || (x < x3 || x > x4 || y > y3 || y < y4))
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
