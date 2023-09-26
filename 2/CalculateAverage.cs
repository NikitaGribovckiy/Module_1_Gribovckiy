using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class CalculateAverage 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Введите три числа для вычисления среднего арифметического."); 
            double sum = 0; // Инициализируем переменную для хранения суммы введенных чисел

            for (int i = 0; i < 3; i++) // Цикл для ввода трех чисел
            {
                Console.Write("Введите число {0}: ", i + 1); 

                try 
                {
                    double number = double.Parse(Console.ReadLine()); // Считываем введенное пользователем число и преобразуем его в число с плавающей запятой
                    sum += number; // Добавляем введенное число к сумме
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Введите число в правильном формате."); // Если пользователь ввел нечто отличное от числа, выводим сообщение об ошибке
                    i--; // Повторяем ввод для того же числа, чтобы пользователь мог ввести правильное значение
                }
            }

            double average = sum / 3; // Вычисляем среднее арифметическое
            Console.WriteLine("Среднее арифметическое: {0}", average); 
        }
    }
}
