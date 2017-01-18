using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            var birthDate = Console.ReadLine();

            string format = "dd-MM-yyyy";

            DateTime dateTime = DateTime.ParseExact(birthDate, format, CultureInfo.InvariantCulture);
            dateTime = dateTime.AddDays(999);
            Console.WriteLine(dateTime.ToString(format));
        }
    }
}
