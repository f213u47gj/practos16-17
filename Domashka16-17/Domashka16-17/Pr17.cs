using System;
using System.Linq;

namespace Domashka16_17 // имя простарансатва
{
    public class Pr17 // класс
    {
        public void outputnumbers() // метод 1 
        {
            int n; // создал переменную
            do // начало цикла
            {
                Console.Write("Введите число от 0 до 50: "); // запрос пользователю
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 50); // цикл для проверки

            for (int i = 0; i <= n; i++) // начало цикла
            {
                Console.Write($"{i}"); // вывод чисел
            }
            Console.WriteLine();
        }

        public void Min() // метод 2
        {
            int n; // создал переменную
            do // начало цикла
            {
                Console.Write("Введите число от 0 до 50: "); // запрос пользователю
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 50); // цикл для проверки

            string[] ggez = new string[n]; //  создаем массив

            for (byte i = 0; i < ggez.Length; i++) // начало цикла 
            {
                Console.Write("Введит число: "); // ввод чисел по индексам
                ggez[i] = Console.ReadLine() ?? string.Empty; // заполняем индекс

            }
            Console.WriteLine($"Минимальный это - {ggez.Min()}"); // вывод минимального

        }


    }
}
