using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());

            decimal price = 0;

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    price = 0.50M;
                }
                else if (product == "water")
                {
                    price = 0.80M;
                }
                else if (product == "beer")
                {
                    price = 1.20M;
                }
                else if (product == "sweets")
                {
                    price = 1.45M;
                }
                else
                {
                    price = 1.60M;
                }

            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    price = 0.40M;
                }
                else if (product == "water")
                {
                    price = 0.70M;
                }
                else if (product == "beer")
                {
                    price = 1.15M;
                }
                else if (product == "sweets")
                {
                    price = 1.30M;
                }
                else
                {
                    price = 1.50M;
                }
            }
            else
            {
                if (product == "coffee")
                {
                    price = 0.45M;
                }
                else if (product == "water")
                {
                    price = 0.70M;
                }
                else if (product == "beer")
                {
                    price = 1.10M;
                }
                else if (product == "sweets")
                {
                    price = 1.35M;
                }
                else
                {
                    price = 1.55M;
                }
            }

            decimal priceTotal = price * quantity;
            Console.WriteLine("{0:0.0####}", priceTotal);
        }
    }
}
