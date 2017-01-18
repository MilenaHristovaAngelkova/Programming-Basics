using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sumEven = 0;
            double sumOdd = 0;
            double numMaxEven = double.MaxValue;
            double numMaxOdd = double.MaxValue;
            double numMinEven = double.MinValue;
            double numMinOdd = double.MinValue;

            if (n == 0)
            {
                    Console.WriteLine("OddSum=0,");
                    Console.WriteLine("OddMin=No,");
                    Console.WriteLine("OddMax=No,");
                    Console.WriteLine("EvenSum=0,");
                    Console.WriteLine("EvenMin=No,");
                    Console.WriteLine("EvenMax=No");                
            }

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 1)
                {
                    sumOdd += num;

                    if (i == 1)
                    {
                        numMaxOdd = numMinOdd = num;
                    }
                    else if (numMaxOdd < num)
                    {
                        numMaxOdd = num;
                    }
                    else if (numMinOdd > num)
                    {
                        numMinOdd = num;
                    }
                }

                if (i % 2 == 0)
                {
                    sumEven += num;

                    if (i == 1 || i == 2)
                    {
                        numMaxEven = numMinEven = num;
                    }
                    else if (numMaxEven < num)
                    {
                        numMaxEven = num;
                    }
                    else if (numMinEven > num)
                    {
                        numMinEven = num;
                    }                  
                }
                         
                if (sumOdd != 0 && sumEven != 0)
                {
                    Console.WriteLine("OddSum=" + sumOdd + ",");
                    Console.WriteLine("OddMin=" + numMinOdd + ",");
                    Console.WriteLine("OddMax=" + numMaxOdd + ",");
                    Console.WriteLine("EvenSum=" + sumEven + ",");
                    Console.WriteLine("EvenMin=" + numMinEven + ",");
                    Console.WriteLine("EvenMax=" + numMaxEven);
                }
                else if (sumOdd != 0 && sumEven == 0)
                {
                    Console.WriteLine("OddSum=" + sumOdd + ",");
                    Console.WriteLine("OddMin=" + numMinOdd + ",");
                    Console.WriteLine("OddMax=" + numMaxOdd + ",");
                    Console.WriteLine("EvenSum=" + sumEven + ",");
                    Console.WriteLine("EvenMin=No,");
                    Console.WriteLine("EvenMax=No");
                }
                else if (sumOdd == 0 && sumEven != 0)
                {
                    Console.WriteLine("OddSum=" + sumOdd + ",");
                    Console.WriteLine("OddMin=No,");
                    Console.WriteLine("OddMax=No,");
                    Console.WriteLine("EvenSum=" + sumEven + ",");
                    Console.WriteLine("EvenMin=" + numMinEven + ",");
                    Console.WriteLine("EvenMax=" + numMaxEven);
                }
            }
        }
    }
}
