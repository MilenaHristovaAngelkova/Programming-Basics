using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            decimal sales = decimal.Parse(Console.ReadLine());

            decimal comission = -1.00M;

            if (city == "sofia")
            {
                if (sales >= 0 && sales <= 500) comission = 0.05M;
                else if (sales > 500 && sales <= 1000) comission = 0.07M;
                else if (sales > 1000 && sales <= 10000) comission = 0.08M;
                else comission = 0.12M;
            }
            else if (city == "varna")
            {
                if (sales >= 0 && sales <= 500) comission = 0.045M;
                else if (sales > 500 && sales <= 1000) comission = 0.075M;
                else if (sales > 1000 && sales <= 10000) comission = 0.10M;
                else comission = 0.13M;
            }
            else if (city == "plovdiv")
            {
                if (sales >= 0 && sales <= 500) comission = 0.055M;
                else if (sales > 500 && sales <= 1000) comission = 0.08M;
                else if (sales > 1000 && sales <= 10000) comission = 0.12M;
                else if (sales > 10000) comission = 0.145M;
            }
            if (comission >= 0)
            {
                Console.WriteLine("{0:F2}", sales * comission);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
