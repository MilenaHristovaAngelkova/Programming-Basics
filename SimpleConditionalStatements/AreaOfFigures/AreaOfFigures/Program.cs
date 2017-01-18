using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double area = 0;

            if (figureType == "square")
            {
                var a = double.Parse(Console.ReadLine());
                area = a * a;
            }
            else if (figureType == "rectangle")
            {
                var b = double.Parse(Console.ReadLine());
                var c = double.Parse(Console.ReadLine());
                area = b * c;
            }
            else if (figureType == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
            }
            else if (figureType == "triangle")
            {
                var d = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                area = (d * h) / 2;
            }

            area = Math.Round(area, 3);
            Console.WriteLine(area);
        }
    }
}
