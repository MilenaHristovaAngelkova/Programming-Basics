using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            decimal quantity = decimal.Parse(Console.ReadLine());

            decimal price = -1.00M;

            bool fruitRange = fruit == "banana" || fruit == "apple" || fruit == "orange" || fruit == "grapefruit"
                || fruit == "kiwi" || fruit == "pineapple" || fruit == "grapes";
            bool dayRange1 = day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday"
                    || day == "friday";
            bool dayRange2 = day == "saturday" || day == "sunday";

            if (!fruitRange)
            {
                Console.WriteLine("error");
            }
            else if (fruitRange && dayRange1)
            {
                switch (fruit)
                {
                    case "banana": price = 2.50M; break; 
                    case "apple": price = 1.20M; break;
                    case "orange": price = 0.85M; break;
                    case "grapefruit": price = 1.45M; break;
                    case "kiwi": price = 2.70M; break;
                    case "pineapple": price = 5.50M; break;
                    case "grapes": price = 3.85M; break;
                    default:
                        break;                     
                }
            }
            else if (fruitRange && dayRange2)
            {
                switch (fruit)
                {
                    case "banana": price = 2.70M; break;
                    case "apple": price = 1.25M; break;
                    case "orange": price = 0.90M; break;
                    case "grapefruit": price = 1.60M; break;
                    case "kiwi": price = 3.00M; break;
                    case "pineapple": price = 5.60M; break;
                    case "grapes": price = 4.20M; break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            
            decimal priceTotal = price * quantity;
            Console.WriteLine("{0:F2}", priceTotal);
        }
    }
}
