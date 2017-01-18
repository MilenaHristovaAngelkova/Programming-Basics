using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattlesMyExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokemonsPlayer1 = int.Parse(Console.ReadLine());
            int pokemonsPlayer2 = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int battlesCount = 0;

            for (int i = 1; i <= pokemonsPlayer1; i++)
            {
                for (int j = 1; j <= pokemonsPlayer2; j++)
                {
                    if (battlesCount == maxBattles)
                    {
                        break;
                    }
                    else
                    {
                        Console.Write("({0} <-> {1}) ", i, j);
                    }
                    battlesCount++;                             
                }                         
            }
            Console.WriteLine();
        }
    }
}
                                         
        
