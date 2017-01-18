using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var bgn = 1;
            var bgnToUsd = 1.79549;
            var bgnToEur = 1.95583;
            var bgnToGbp = 2.53405;

            var currency = double.Parse(Console.ReadLine());
            var from = Console.ReadLine();
            var to = Console.ReadLine();

            if (from == "BGN")
            {
                currency = currency * bgn;
            }         
            else if (from == "USD")
            {
                currency = currency * bgnToUsd;
            }
            else if (from == "EUR")
            {
                currency = currency * bgnToEur;
            }
            else if (from == "GBP")
            {
                currency = currency * bgnToGbp;
            }

            if (to == "BGN")
            {
                currency = currency / bgn;
            }
            else if (to == "USD")
            {
                currency = currency / bgnToUsd;
            }
            else if (to == "EUR")
            {
                currency = currency / bgnToEur;
            }
            else if (to == "GBP")
            {
                currency = currency / bgnToGbp;
            }

            currency = Math.Round(currency, 2);
            Console.WriteLine("{0} {1}", currency, to);
        }
    }
}
