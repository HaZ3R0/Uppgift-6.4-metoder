using System;
namespace HejAmeen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in din bas");
            double bas = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in din exponent");
            double exponent = double.Parse(Console.ReadLine());
            Console.WriteLine("talet blir " + Potens (bas, exponent));
        }

        static double Potens(double bas, double exponent)
        {
            double a = 1;
            for (int i = 0; i < exponent; i++)
            {
                a *= bas;
            }
            return a;
        }
    }
}