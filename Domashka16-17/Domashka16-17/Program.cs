using System;

namespace Domashka16_17
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Задание 1");
            Pr16 pr16 = new Pr16();
            pr16.SumSin();
            Console.WriteLine("Задание 2");
            pr16.count5(new int[] {5, 5, 5, 5, 3, 3, 2, 5, 4, 5, 2, 4, 2 });

            Console.WriteLine();

            Console.WriteLine("Задание 1");
            Pr17 pr17 = new Pr17();
            pr17.outputnumbers();
            Console.WriteLine("Задание 2");
            pr17.Min();
            
        }
    }
}
