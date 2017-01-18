using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());           
            int sum = 0;
            int numMax = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;

                if (i == 0)
                {
                    numMax = num;                    
                }
                else if (numMax < num)
                {
                    numMax = num;
                }

                int difference = sum - numMax;

                if (difference == numMax)
                {
                    Console.WriteLine("Yes");
                    Console.WriteLine("Sum = " + numMax);
                }
                else
                {
                    Console.WriteLine("No");
                    Console.WriteLine("Diff = " + Math.Abs(sum - 2*numMax));

                }
            }                
        }
    }
}
