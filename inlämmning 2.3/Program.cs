using System;
namespace Uppgift_2._3
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("hej hur många dagar ska du hyra en bil");
            string dagarText=Console.ReadLine();
            int dagar=int.Parse(dagarText);
            Console.WriteLine("hur många kilometer ska du köra");
            string kilometerText=Console.ReadLine();
            int kilometer=int.Parse(kilometerText);
            int summa = 300 + (dagar - 1) * 500 + (kilometer * 1);
            Console.WriteLine("Priset kommer att bli " + summa+ "kr");
        }
    }
}
