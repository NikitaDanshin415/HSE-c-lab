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

            /*«Возьмем любое натуральное число. Если оно четное – разделим его пополам, если 
             * нечетное – умножим на 3, прибавим 1 и разделим пополам. Повторим эти действия с вновь 
             * полученным числом.» Гипотеза гласит, что независимо от выбора первого числа рано или поздно мы получим 1. Разработать программу, 
             * проверяющую данную гипотезу. Вывести текущее число на каждой итерации и итоговое число итераций. (0,5 балла)
             */

            int x, count = 0;

            Console.Write("Введите натуральное число  = ");

            while ((!int.TryParse(Console.ReadLine(), out x)) || (x < 0))
            {
                Console.WriteLine("Ошибка ввода, число X должно быть целочисленным положительным числом");
                Console.Write("Попробуйте еще раз, X = ");
            };

            while( x != 1)
            {
                if(x % 2 == 0)
                {
                    x = x / 2;
                }else
                {
                    x = (x * 3 + 1)/2;
                }
                count++;
                Console.WriteLine($"Иттерация №{count} = {x}");
            }
            Console.WriteLine($"Общее количество иттераций {count}");
        }
    }
}
