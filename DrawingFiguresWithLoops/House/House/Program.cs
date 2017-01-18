using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                int rowsRoof = n / 2;
                int asterixCount = n - (n - 2);
                for (int rowRoofEven = 0; rowRoofEven < rowsRoof; rowRoofEven++)
                {
                    int dashesCount = (n - asterixCount) / 2;
                    Console.Write("{0}{1}{0}", new string('-', dashesCount), new string('*', asterixCount));
                    asterixCount += 2;

                    Console.WriteLine();
                }
            }
            else if (n % 2 == 1)
            {
                int rowsRoof = n / 2 + 1;
                int asterixCount = 1;
                for (int rowRoofEven = 0; rowRoofEven < rowsRoof; rowRoofEven++)
                {
                    int dashesCount = (n - asterixCount) / 2;
                    Console.Write("{0}{1}{0}", new string('-', dashesCount), new string('*', asterixCount));
                    asterixCount += 2;

                    Console.WriteLine();
                }
            }
            for (int rowHouse = 0; rowHouse < n / 2; rowHouse++)
            {
                Console.Write("|{0}|", new string('*', n - 2));
                Console.WriteLine();
            }            
        }
    }
}