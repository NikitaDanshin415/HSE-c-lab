using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Даньшин Никита, ПИ-18У, Вариант №6, Задание №1");
            Console.WriteLine();
            double m, n;
            Console.WriteLine("----------------------------1[m++ +n]------------------------------------------");
            Console.WriteLine("Введите M = ");
            while (!double.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Ошибка ввода, N должен быть целочисленным числом. ");
                Console.WriteLine("Введите M = ");
            }
            Console.WriteLine();

            Console.WriteLine("Введите N = ");
            while (!double.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода, N должен быть целочисленным числом.");
                Console.WriteLine("Введите N = ");
            }
            Console.WriteLine();

            double k = m / --n;
            Console.WriteLine("m++ +n={0}, m={1},n={2}", k, m, n);

            Console.WriteLine("----------------------------2[m++>--n]------------------------------------------");
            Console.WriteLine("Введите M = ");
            while (!double.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Ошибка ввода, N должен быть целочисленным числом. ");
                Console.WriteLine("Введите M = ");
            }
            Console.WriteLine();

            Console.WriteLine("Введите N = ");
            while (!double.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода, N должен быть целочисленным числом.");
                Console.WriteLine("Введите N = ");
            }
            Console.WriteLine();

            bool z = m++ > --n;
            Console.WriteLine("m++>--n={0}, m={1},n={2}", z, m, n);

            Console.WriteLine("----------------------------3[m--<++n]------------------------------------------");
            Console.WriteLine("Введите M = ");
            while (!double.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Ошибка ввода, N должен быть целочисленным числом. ");
                Console.WriteLine("Введите M = ");
            }
            Console.WriteLine();

            Console.WriteLine("Введите N = ");
            while (!double.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода, N должен быть целочисленным числом.");
                Console.WriteLine("Введите N = ");
            }
            Console.WriteLine();

            z = m-- < ++n;
            Console.WriteLine("m--<++n={0}, m={1},n={2}", z, m, n);

            Console.WriteLine("----------------------------4------------------------------------------");
            double x;
            Console.WriteLine("Введите X = ");

            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Ошибка ввода, X должен быть целочисленным числом.");
                Console.WriteLine("Введите X = ");
            }


            Console.WriteLine();
            Console.WriteLine(25*Math.Pow(x,5)-Math.Sqrt(Math.Pow(x,2)+x));
           
        }
    }
}
