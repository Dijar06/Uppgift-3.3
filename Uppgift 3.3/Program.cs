using System;

namespace Uppgift3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många timmar vill du hyra bilen?");
            int timmar = int.Parse(Console.ReadLine());
            int pris = timmar * 80;

            if (pris > 950)
            {
                Console.WriteLine("Priset blir 950 kronor.");
            }
            else
            {
                Console.WriteLine("Priset blir " + pris);
            }
        }
    }
}