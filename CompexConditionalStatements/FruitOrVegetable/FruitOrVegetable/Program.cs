using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string submittedInput = Console.ReadLine();

            if (submittedInput == "banana" || submittedInput == "apple" || submittedInput == "kiwi"
                || submittedInput == "cherry" || submittedInput == "lemon" || submittedInput == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (submittedInput == "tomato" || submittedInput == "cucumber" || submittedInput == "pepper"
                || submittedInput == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
