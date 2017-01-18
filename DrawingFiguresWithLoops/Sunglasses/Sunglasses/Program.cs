using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string asterixCountFrame = new string('*', 2 * n);
            string spacesCountFrame = new string(' ', n);
            Console.WriteLine("{0}{1}{0}", asterixCountFrame, spacesCountFrame);

            for (int row = 0; row <= n - 3; row++)
            {                
                if ((n % 2 == 1 && row == ((n - 3) / 2)) || (n % 2 == 0 && row == (n / 2) - 2))
                {
                        string line = new string('|', n);
                        string slashCount = new string('/', (2 * n) - 2);
                        char asterix = '*';
                        Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", asterix, slashCount, line);
                    }
                    else
                    {
                        string spacesCount = new string(' ', n);
                        string slashCount = new string('/', (2 * n) - 2);
                        char asterix = '*';
                        Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", asterix, slashCount, spacesCount);
                    }   
           }
            Console.WriteLine("{0}{1}{0}", asterixCountFrame, spacesCountFrame, asterixCountFrame);
        }
    }
}
