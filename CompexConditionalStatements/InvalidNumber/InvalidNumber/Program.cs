using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool inRange = (number >= 100 && number <= 200) || number == 0;
            if (!inRange)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
///

            /*
        {
           // int number = int.Parse(Console.ReadLine());
           // bool inRange = (number >= 100 && number <= 200) || number == 0;
            string[] array = { "one", "two", "three" };
            for (int i = 0; i < array.Length; i++)
            {
                bool isTrue = array[i] == "one";
                if (isTrue)
                {
                    Console.WriteLine(array[i]);
                }
            }
          //  if (!inRange)
            //{
             //   Console.WriteLine("invalid");
            //}
        }
    }
}

 //
            *
            int number = int.Parse(Console.ReadLine());

            if (number >= 100 && number <= 200)
            {
                Console.WriteLine();
            }
            else if (number == 0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("invalid");
            }
            *\
        }
    }
}