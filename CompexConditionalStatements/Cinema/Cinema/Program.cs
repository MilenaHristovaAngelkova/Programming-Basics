using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            decimal price = 0;

            switch (projectionType)
            {
                case "Premiere": price = 12.00M; break;
                case "Normal": price = 7.50M; break;
                case "Discount": price = 5.00M; break;
                default:
                    break;
            }

            decimal profit = rows * columns * price;
            Console.WriteLine("{0:F2}" + " leva", profit);
        }
    }
}
