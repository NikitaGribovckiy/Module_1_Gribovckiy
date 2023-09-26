using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class PrintFizzBuzz
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++) // Цикл от 1 до 100
            {
                string output = ""; // Создаем пустую строку для формирования вывода

                if (i % 3 == 0) // Если число делится на 3 без остатка (кратно 3)
                    output += "Fizz"; // Добавляем "Fizz" к строке

                if (i % 5 == 0) // Если число делится на 5 без остатка (кратно 5)
                    output += "Buzz"; // Добавляем "Buzz" к строке

                if (string.IsNullOrEmpty(output)) // Если строка пуста (число не делится ни на 3, ни на 5)
                    output = i.ToString(); // Просто добавляем число как строку

                Console.Write(output.PadRight(10)); // Выводим строку, выравнивая ее по правому краю до ширины 10 символов
                if (i % 10 == 0) // Если достигнут конец строки (каждая десятая итерация)
                    Console.WriteLine(); // Переходим на новую строку
            }
        }
    }
}
