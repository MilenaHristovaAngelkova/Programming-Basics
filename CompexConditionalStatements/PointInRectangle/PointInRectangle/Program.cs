﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal x1 = decimal.Parse(Console.ReadLine());
            decimal y1 = decimal.Parse(Console.ReadLine());
            decimal x2 = decimal.Parse(Console.ReadLine());
            decimal y2 = decimal.Parse(Console.ReadLine());
            decimal x = decimal.Parse(Console.ReadLine());
            decimal y = decimal.Parse(Console.ReadLine());

            if (x1 < x2 && y1 < y2)
            {
                if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
                {
                    Console.WriteLine("Inside");
                }
                else
                {
                    Console.WriteLine("Outside");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
