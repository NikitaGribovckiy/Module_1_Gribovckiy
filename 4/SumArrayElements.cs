using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class SumArrayElements
    {
        static void Main(string[] args)
        {
            // Создаем массив из 10 случайных целых чисел
            int[] array = new int[10];
            Random random = new Random(); // Создаем объект для генерации случайных чисел

            for (int i = 0; i < 10; i++) // Заполняем массив случайными числами от 1 до 100
            {
                array[i] = random.Next(1, 101);
            }

            int sum = 0; // Инициализируем переменную для хранения суммы элементов массива

            Console.WriteLine("Массив случайных чисел:"); // Выводим заголовок

            foreach (int number in array) // Проходим по каждому элементу массива
            {
                Console.Write(number + " "); // Выводим элемент на экран с пробелом
                sum += number; // Добавляем элемент к сумме
            }

            Console.WriteLine("\nСумма элементов массива: {0}", sum); // Выводим общую сумму элементов массива
        }
    }
}
