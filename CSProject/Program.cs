using System;

namespace CSProject
{
    class Program
    {


        static void Main()
        {
            int number1;
            string action;
            double number2;

            while (true)
            {
                Console.WriteLine("Введите первое число");
                bool TryParse1 = int.TryParse(Console.ReadLine(), out number1);
                if (!TryParse1)
                {
                    Console.WriteLine("Ошибка ввода");
                    continue;
                }

                Console.WriteLine("Введите действие (для выхода введите 'exit')");

                action = Console.ReadLine();
                if (action == "exit")
                {
                    Console.WriteLine("Выход из программы");
                    break;
                }
                Console.WriteLine("Введите второе число");
                bool TryParse2 = double.TryParse(Console.ReadLine(), out number2);
                if (!TryParse2)
                {
                    Console.WriteLine("Ошибка ввода");
                    continue;
                }

                Operation(number1, action, number2);

            }





        }

        static void Operation(int number1, string action, double number2 )
        {
            switch (action)
            {
                case "+":
                    Console.WriteLine($"Результат: {number1 + number2}");
                    break;
                case "-":
                    Console.WriteLine($"Результат: {number1 - number2}");
                    break;
                case "%":
                    Console.WriteLine($"Результат: {number1 % number2}");
                    break;
                case "*":
                    Console.WriteLine($"Результат: {number1 * number2}");
                    break;
                case "**":
                    Console.WriteLine($"Результат: {Math.Pow(number1, number2)}");
                    break;

                case "/":
                    if (number2 == 0)
                    {
                        Console.WriteLine("НА НОЛЬ ДЕЛИТЬ НЕЛЬЗЯ");
                    }
                    else
                    {
                        Console.WriteLine($"Результат: {number1 / number2}");
                    }

                    break;
                default:
                    Console.WriteLine("Неизвестная операция");
                    break;
            }


        }
    }
}
