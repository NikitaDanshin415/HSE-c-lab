using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Пользователь вводит целое положительное число. Определить является ли оно степенью числа 3

            int x, result = 1;

            Console.Write("Введите число X  = ");

            while ((!int.TryParse(Console.ReadLine(), out x)) || (x < 0))
            {
                Console.WriteLine("Ошибка ввода, число X должно быть целочисленным положительным числом");
                Console.Write("Попробуйте еще раз, X = ");
            };

            while (result < x)
            {
                result *= 3;
            }

            if (result == x)
            {
                Console.WriteLine("da");
            }else
            {
                Console.WriteLine("net");
            }

        }
    }
}
