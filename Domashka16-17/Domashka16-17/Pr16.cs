using System;
using System.Configuration;
using System.Linq;

namespace Domashka16_17 // имя пространства 
{
    public class Pr16 // класс Практоса 16
    {
        public void SumSin() // метод для задания 1
        {
            int n; // создал переменную
            do // начало цикла
            {
                Console.Write("Введите натуральное число n: "); // запрос пользователю
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 0
            ); // цикл для проверки

            double resualt = 0; // создаем переменную
            double sinsum = 0; //  создаем переменную

            for (int i = 1; i <= n; i++) // цикл
            {
                sinsum += Math.Sin(i); // считаем синус 
                resualt += 1 / sinsum; // получение результата
            }
            Console.WriteLine($"Сумма = {resualt}"); // вывод результата
        }

        public void count5(int[] mass) // метод для задания 2 
        { 
        Console.WriteLine($"Пятерки у {mass.Count(x => x == 5)} Челчелов"); // получение кол-во пятерок
        }





    }
}
