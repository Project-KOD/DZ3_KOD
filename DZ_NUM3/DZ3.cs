using System;

//ПЕРВАЯ ЧАСТЬ ТРЕТЬЕГО ДЗ

namespace DZ3_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double b = double.Parse(Console.ReadLine());

            double sum = a + b;
            Console.WriteLine($"Сумма равна: {sum}");
        }

    }
}

//ВТОРАЯ ЧАСТЬ ТРЕТЬЕГО ДЗ

/*namespace DZ3_2
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int numSecret = random.Next(1, 101);

            Console.WriteLine("Попробуй отгадать число, которое я загадал.");
            int userGuess = 0;

            while (userGuess != numSecret)
            {
                Console.Write("Введите ваше предположение (число от 1 до 100): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out userGuess))
                {
                    if (userGuess < numSecret)
                    {
                        Console.WriteLine("Ваше число меньше загаданного.");
                    }
                    else if (userGuess > numSecret)
                    {
                        Console.WriteLine("Ваше число больше загаданного.");
                    }
                }
                else
                {
                    Console.WriteLine("Пожалуйста, введите корректное число.");
                }
            }

            Console.WriteLine("ВЕРНО! Вы угадали число!");
        }
    }
}*/