using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleOfNByNStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
           
            for (int currRow = 0; currRow < rows; currRow++)
            {
                Console.WriteLine(new string('*', rows));
            }
        }
    }
}
