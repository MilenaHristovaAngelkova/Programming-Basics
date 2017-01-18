using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int digit = 1;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    if (col == 1)
                    {
                        Console.Write(digit);
                        digit++;
                        if (digit > n)
                        {
                            break;
                        }
                    }
                    else if (col > 1)
                    {
                        Console.Write(" ");
                        Console.Write(digit);
                        digit++;
                        if (digit > n)
                        {
                            break;
                        }
                    }
                }
                Console.WriteLine();
                if (digit > n)
                {
                    break;
                }
            }
        }
    }
}
