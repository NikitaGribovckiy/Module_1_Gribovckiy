using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Выводим меню для выбора задания
            Console.WriteLine("Задания:");
            Console.WriteLine("1. Угадай число (генерирует случайное число и предлагает угадать).");
            Console.WriteLine("2. Вычисление среднего арифметического трех чисел.");
            Console.WriteLine("3. Проверка подстроки (определяет, является ли вторая строка подстрокой первой).");
            Console.WriteLine("4. Сумма элементов массива из 10 случайных чисел.");
            Console.WriteLine("5. FizzBuzz (выводит числа от 1 до 100, заменяя числа, которые делятся на 3 и/или 5 на Fizz и/или Buzz).");
            Console.WriteLine("Выберите задание для выполнения (1-5), или 0 для выхода:");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    GuessNumberGame(); // Вызываем функцию для игры "Угадай число"
                    break;
                case 2:
                    CalculateAverage(); // Вызываем функцию для вычисления среднего арифметического
                    break;
                case 3:
                    CheckSubstring(); // Вызываем функцию для проверки подстроки
                    break;
                case 4:
                    SumArrayElements(); // Вызываем функцию для суммирования элементов массива
                    break;
                case 5:
                    PrintFizzBuzz(); // Вызываем функцию для вывода FizzBuzz
                    break;
                case 0:
                    Console.WriteLine("Выход из программы."); // Завершаем программу
                    return;
                default:
                    Console.WriteLine("Некорректный выбор задания. Попробуйте снова.");
                    break;
            }
        }
    }

    static void GuessNumberGame()
    {
        Random random = new Random();
        int targetNumber = random.Next(1, 101);
        int attempts = 0;

        Console.WriteLine("Угадайте число от 1 до 100.");

        while (true)
        {
            attempts++;
            Console.Write("Попытка {0}: Введите вашу догадку: ", attempts);

            try
            {
                int guess = int.Parse(Console.ReadLine());

                if (guess < targetNumber)
                    Console.WriteLine("Загаданное число больше.");
                else if (guess > targetNumber)
                    Console.WriteLine("Загаданное число меньше.");
                else
                {
                    Console.WriteLine("Поздравляем! Вы угадали число {0} за {1} попыток.", targetNumber, attempts);
                    break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Введите целое число.");
            }
        }
    }

    static void CalculateAverage()
    {
        Console.WriteLine("Введите три числа для вычисления среднего арифметического.");
        double sum = 0;

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Введите число {0}: ", i + 1);

            try
            {
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Введите число в правильном формате.");
                i--; // Повторяем ввод для того же числа
            }
        }

        double average = sum / 3;
        Console.WriteLine("Среднее арифметическое: {0}", average);
    }

    static void CheckSubstring()
    {
        Console.WriteLine("Введите первую строку:");
        string str1 = Console.ReadLine();

        Console.WriteLine("Введите вторую строку для проверки подстроки:");
        string str2 = Console.ReadLine();

        if (str1.Contains(str2))
            Console.WriteLine("Вторая строка является подстрокой первой строки.");
        else
            Console.WriteLine("Вторая строка не является подстрокой первой строки.");
    }


    static void SumArrayElements()
    {
        // Создаем массив из 10 случайных целых чисел
        int[] array = new int[10];
        Random random = new Random();

        for (int i = 0; i < 10; i++)
        {
            array[i] = random.Next(1, 101);
        }

        int sum = 0;

        Console.WriteLine("Массив случайных чисел:");
        foreach (int number in array)
        {
            Console.Write(number + " ");
            sum += number;
        }

        Console.WriteLine("\nСумма элементов массива: {0}", sum);
    }

    static void PrintFizzBuzz()
    {
        // Выводим числа от 1 до 100 и заменяем числа, которые делятся на 3 и/или 5 на Fizz и/или Buzz
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
    }
}
