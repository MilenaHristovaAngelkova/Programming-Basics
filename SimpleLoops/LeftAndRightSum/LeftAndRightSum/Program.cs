﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftSum = leftSum + num;
            }
            for (int i = 0; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                rightSum = rightSum + num1;
            }
            if (Math.Abs(leftSum - rightSum) == 0)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftSum - rightSum));
            }
        }
    }
}
