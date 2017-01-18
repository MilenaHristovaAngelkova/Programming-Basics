using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var score1 = int.Parse(Console.ReadLine());
            var score2 = int.Parse(Console.ReadLine());
            var score3 = int.Parse(Console.ReadLine());

            var scoreTotal = score1 + score2 + score3;

            var minutes = scoreTotal / 60;
            var seconds = scoreTotal % 60;

            if (seconds > 9)
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":0" + seconds);
            }
        }
    }
}
