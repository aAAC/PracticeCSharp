using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace TechDoctor
{
    public class Discards
    {
        public static void TestDiscards()
        {
            var (_, _, _, pop1, _, pop2) = QueryCityDataForYears("Lahore", 1960, 2020);

            Console.WriteLine($"pop1 = {pop1}, pop2 = {pop2}" );
        }

        private static (string, double, int, int, int, int) QueryCityDataForYears(string name, int yea1, int year2)
        {
            return ("Lahore", 5.0, 1, 2, 3, 4);
        }
    }
}