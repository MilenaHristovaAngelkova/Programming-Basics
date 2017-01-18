using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxCombinationExamEveNov2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int maxCombinations = int.Parse(Console.ReadLine());

            int combinationsCount = 0;

            for (int i = num1; i <= num2; i++)
            {
                for (int j = num1; j <= num2; j++)
                {
                    if (combinationsCount == maxCombinations)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("<{0}-{1}>", i, j);
                    }
                    combinationsCount++;
                }
            }
            Console.WriteLine();
        }
    }
}
