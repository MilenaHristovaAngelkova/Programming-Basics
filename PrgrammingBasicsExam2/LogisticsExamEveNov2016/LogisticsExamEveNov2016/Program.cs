using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticsExamEveNov2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLoads = int.Parse(Console.ReadLine());

            int sum = 0;
            double loadMinibus = 0.00;
            double loadTruck = 0.00;
            double loadTrain = 0.00;

            for (int i = 0; i < numberOfLoads; i++)
            {
                int tonsPerLoad = int.Parse(Console.ReadLine());
                sum += tonsPerLoad;

                if (tonsPerLoad <= 3)
                {
                    loadMinibus += tonsPerLoad;
                }
                else if (tonsPerLoad > 3 && tonsPerLoad < 12)
                {
                    loadTruck += tonsPerLoad;
                }
                else if (tonsPerLoad > 11)
                {
                    loadTrain += tonsPerLoad;
                }
            }

            double averagePricePerTon = ((loadMinibus * 200) + (loadTruck * 175)
                + (loadTrain * 120)) / sum;
            double tonsPerMinibus = (loadMinibus / sum) * 100.00;
            double tonsPerTruck = (loadTruck / sum) * 100.00;
            double tonsPerTrain = (loadTrain / sum) * 100.00;

            Console.WriteLine("{0:f2}", averagePricePerTon);
            Console.WriteLine("{0:f2}%", tonsPerMinibus);
            Console.WriteLine("{0:f2}%", tonsPerTruck);
            Console.WriteLine("{0:f2}%", tonsPerTrain);
        }
    }
}
