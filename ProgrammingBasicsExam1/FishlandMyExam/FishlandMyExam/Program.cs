using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishlandMyExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double fishSkumriaPricePerKg = double.Parse(Console.ReadLine());
            double fishTsatsaPricePerKg = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            double kgMidi = double.Parse(Console.ReadLine());

            double palamudFishPricePerKg = fishSkumriaPricePerKg + (fishSkumriaPricePerKg * 0.60);
            double safridFishPricePerKg = fishTsatsaPricePerKg + (fishTsatsaPricePerKg * 0.80);
            double midiPricePerKg = 7.50;

            double priceTotal = (palamudFishPricePerKg * kgPalamud) + (safridFishPricePerKg * kgSafrid)
                + (midiPricePerKg * kgMidi);
           
            Console.WriteLine("{0:f2}", priceTotal);
        }
    }
}
