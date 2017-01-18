﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            var temperatureCelsium = double.Parse(Console.ReadLine());
            var temperatureFahrenheit = temperatureCelsium * 9 / 5 + 32;

            Console.WriteLine(Math.Round(temperatureFahrenheit,2));
        }
    }
}
