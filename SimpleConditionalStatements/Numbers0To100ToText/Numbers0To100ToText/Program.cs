using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers0To100ToText
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int hundred = number / 100;
            int tenth = number / 10;
            int unit = number % 10;
            string str = null;

            string[] units = { null, "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "sventeen", "eightteen", "nineteen" };
            string[] tenths = { null, "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (number < 0 || number > 100)
            {
                Console.WriteLine("invalid number");
            }
            else if (number == 0)
            {
                Console.WriteLine("zero");
            }
            else
                {
                if (number >= 0 && number <= 19)
                {
                    str = units[number];
                }
                else if (number >= 20 && number <= 99 && unit == 0)
                {
                    str = tenths[tenth];
                }
                else if (number >= 20 && number <= 99)
                {
                    str = tenths[tenth] + " " + units[unit];
                }
                else if (number == 100)
                {
                    str = units[hundred] + " hundred";
                }
                Console.WriteLine(str);
            }
        }
    }
}