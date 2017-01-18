using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShopExamEveNov2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cacti = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double magnoliaPrice = 3.25;
            double hyacinthPrice = 4.00;
            double rosePrice = 3.50;
            double cactusPrice = 8.00;

            double priceFlowers = (magnoliaPrice * magnolias) + (hyacinthPrice * hyacinths) +
                (rosePrice * roses) + (cactusPrice * cacti);
            double priceTotal = priceFlowers - (priceFlowers * 0.05);
            double difference = Math.Abs(priceTotal - presentPrice);

            if (priceTotal >= presentPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(difference));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(difference));
            }
        }
    }
}
