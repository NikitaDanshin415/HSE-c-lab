using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int n, min = int.MaxValue, el = 0;

            Console.Write("Введите длину последовательности N  = ");

            while ((!int.TryParse(Console.ReadLine(), out n)) && (n == 0))
            {
                Console.WriteLine("Ошибка ввода, число N должно быть целочисленным положительным числом");
                Console.Write("Попробуйте еще раз, N = ");
            };

            for (int i = 0; i <= n - 1; i++)
            {
                Console.Write($"{i + 1} число = ");

                while (!int.TryParse(Console.ReadLine(), out el))
                {
                    Console.WriteLine("Ошибка ввода, все элементы должны быть целочисленным положительным числом");
                    Console.WriteLine($"Попробуйте еще раз");
                    Console.Write($"{i + 1} число = ");
                };

                if (el < min)
                {
                    min = el;
                }
            }
            Console.WriteLine($"Минимальный элемент последовательности = {min}");
        }
    }
}
