using System;

namespace GasCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double regular = 2.19;
            double premium = 2.59;
            const int NUMBER_OF_GALLONS = 14;
            double totalRegularGasCost = NUMBER_OF_GALLONS * regular;
            double totalPremiumGasCost = NUMBER_OF_GALLONS * premium;

            Console.WriteLine("Regular Gas Cost: {0:C} Premium Gas Cost: {1:C}", totalRegularGasCost, totalPremiumGasCost);
        }
    }
}
