using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class GuessNumberGame 
    {
        static void Main(string[] args) 
        {
            Random random = new Random(); // Создаем объект для генерации случайных чисел
            int targetNumber = random.Next(1, 101); // Генерируем случайное число от 1 до 100
            int attempts = 0; // Инициализируем счетчик попыток

            Console.WriteLine("Угадайте число от 1 до 100."); 

            while (true) 
            {
                attempts++; // Увеличиваем счетчик попыток на 1
                Console.Write("Попытка {0}: Введите вашу догадку: ", attempts); // Просим пользователя ввести число

                try 
                {
                    int guess = int.Parse(Console.ReadLine()); // Считываем введенное пользователем число и преобразуем его в целое число

                    if (guess < targetNumber)
                        Console.WriteLine("Загаданное число больше."); // Если введенное число меньше загаданного, выводим подсказку
                    else if (guess > targetNumber)
                        Console.WriteLine("Загаданное число меньше."); // Если введенное число больше загаданного, выводим подсказку
                    else
                    {
                        Console.WriteLine("Поздравляем! Вы угадали число {0} за {1} попыток.", targetNumber, attempts); // Если число угадано, выводим сообщение о победе
                        break; // Выходим из бесконечного цикла
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Введите целое число."); // Если пользователь ввел нечто отличное от целого числа, выводим сообщение об ошибке
                }
            }
        }
    }
}
