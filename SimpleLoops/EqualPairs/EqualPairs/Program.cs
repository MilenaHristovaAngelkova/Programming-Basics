using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());            
            int sumInitialPair = 0;
            int sumConsequitivePair = 0;
            int maxDifference = 1;
            int counter = 0;

            for (int i = 1; i <= n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                sumConsequitivePair = num1 + num2;

                if (sumConsequitivePair == sumInitialPair)
                {
                    counter += 1;
                }
                if (maxDifference < Math.Abs(sumConsequitivePair - sumInitialPair) && i >= 2)
                {
                    maxDifference = Math.Abs(sumConsequitivePair - sumInitialPair);
                }
                if (sumConsequitivePair != sumInitialPair)
                {
                    sumInitialPair = sumConsequitivePair;
                }
            }
            if (counter == n - 1)
            {
                Console.WriteLine("Yes, value={0}", sumConsequitivePair);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDifference);
            }
        }
        }
    }
