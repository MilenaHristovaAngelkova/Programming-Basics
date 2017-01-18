using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var radian = double.Parse(Console.ReadLine());
            var degree = radian * 180 / Math.PI;

            Console.WriteLine(Math.Round(degree));
        }
    }
}
