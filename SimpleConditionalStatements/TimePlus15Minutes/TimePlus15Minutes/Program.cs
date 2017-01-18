using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            int timePlus = minutes + 15;

            if (hour >= 0 && hour <= 23 && minutes >= 0 && minutes <= 59)
            {
                if (timePlus <= 59)
                {
                    if (timePlus > 9)
                    {
                        Console.WriteLine(hour + ":" + timePlus);
                    }
                    else
                    {
                        Console.WriteLine(hour + ":0" + timePlus);
                    }
                }
                else if (timePlus > 59 && hour <= 22)
                {
                    timePlus = timePlus - 60;
                    if (timePlus > 9)
                    {
                        Console.WriteLine((hour + 1) + ":" + timePlus);
                    }
                    else
                    { 
                        Console.WriteLine((hour + 1) + ":" + "0" + timePlus);
                    }
                        }
                else if (timePlus > 59 && hour == 23)
                {
                    timePlus = timePlus - 60;

                    if (timePlus > 9)
                    {
                        Console.WriteLine("0" + ":" + timePlus);
                    }
                    else
                    {
                        Console.WriteLine("0" + ":" + "0" + timePlus);
                    }
                }
            }
                }
            }
        }
