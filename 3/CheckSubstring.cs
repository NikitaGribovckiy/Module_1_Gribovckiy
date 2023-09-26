using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class CheckSubstring 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Введите первую строку:"); // Просим пользователя ввести первую строку
            string str1 = Console.ReadLine(); // Считываем введенную первую строку

            Console.WriteLine("Введите вторую строку для проверки подстроки:"); // Просим пользователя ввести вторую строку для проверки
            string str2 = Console.ReadLine(); // Считываем введенную вторую строку

            if (str1.Contains(str2)) // Проверяем, содержит ли первая строка вторую строку в качестве подстроки
                Console.WriteLine("Вторая строка является подстрокой первой строки."); // Если да, выводим сообщение
            else
                Console.WriteLine("Вторая строка не является подстрокой первой строки."); // Если нет, выводим другое сообщение
        }
    }
}
