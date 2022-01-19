using System;

namespace ICE04
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius = 20;
            const int FREEZING_POINT = 32;
            double fahrenheit = ((9 * celsius) / 5) + FREEZING_POINT;

            Console.WriteLine(fahrenheit); //68
        }
    }
}
