using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = 1;
            var mToMm = 1000;
            var mToCm = 100;
            var mToMi = 0.000621371192;
            var mToIn = 39.3700787;
            var mToKm = 0.001;
            var mToFt = 3.2808399;
            var mToYd = 1.0936133;

            var number = double.Parse(Console.ReadLine());
            var from = Console.ReadLine();
            var to = Console.ReadLine();

            if (from == "mm")
            {
                number = number / mToMm;
            }
            else if (from == "cm")
            {
                number = number / mToCm;
            }
            else if (from == "mi")
            {
                number = number / mToMi;
            }
            else if (from == "in")
            {
                number = number / mToIn;
            }
            else if (from == "km")
            {
                number = number / mToKm;
            }
            else if (from == "ft")
            {
                number = number / mToFt;
            }
            else if (from == "yd")
            {
                number = number / mToYd;
            }

            if (to == "mm")
            {
                number = number * mToMm;
            }
            else if (to == "cm")
            {
                number = number * mToCm;
            }
            else if (to == "mi")
            {
                number = number * mToMi;
            }
            else if (to == "in")
            {
                number = number * mToIn;
            }
            else if (to == "km")
            {
                number = number * mToKm;
            }
            else if (to == "ft")
            {
                number = number * mToFt;
            }
            else if (to == "yd")
            {
                number = number * mToYd;
            }

            Console.WriteLine("{0} {1}", number, to);
        }
    }
}
