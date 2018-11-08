using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program3
    {
        static void Main(string[] args)
        {
            double S = 0;
            double x;
            int n;

            Console.Write("Введите X = ");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Ошибка ввода, число X должно быть числом");
                Console.Write("Попробуйте еще раз, X = ");
            };

            Console.Write("Введите N = ");
            while ((!int.TryParse(Console.ReadLine(), out n)) && (n <= 0))
            {
                Console.WriteLine("Ошибка ввода, число N должно быть целочисленным положительным числом");
                Console.Write("Попробуйте еще раз, N = ");
            };


            for (double i = 0; i <= n; i++) {
                S = S + (Math.Pow(Math.Sin(x),i));
            }
            Console.WriteLine(S);
        }
    }
}
