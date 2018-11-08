using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Даньшин Никита, ПИ-18У, Вариант №6, Задание №2");
            Console.WriteLine();
            double x, y;

            Console.Write("Введите X = ");
            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Ошибка ввода. При вводе принимаются целочисленные и вещественные числа с запятой.");
                Console.Write("Введите X = ");
            }
            Console.WriteLine();

            Console.Write("Введите Y = ");
            while (!double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine("Ошибка ввода. При вводе принимаются целочисленные и вещественные числа с запятой.");
                Console.Write("Введите Y = ");
            }
            Console.WriteLine();
            string sq = "на оси" ;

            if (x!=0 && y!=0) {
                if (x > 0)
                {
                    if (y > 0)
                    {
                        sq = "в первой четверти";
                    }
                    else
                    {
                        if (y < 0)
                            sq = "в четвертой четверти";
                    }
                }
                else {
                    if (y > 0)
                    {
                        sq = "во второй четверти";
                    }
                    else
                    {
                        if (y < 0)
                            sq = "в третей четверти";
                    }

                }
            }
            else
            {
                if (x == 0 && y == 0) {
                    sq = "в центре пересечения осей";
                }
                else
                {
                    if (x == 0)
                    {
                        sq = "на оси x";
                    }
                    else
                    {
                        if (y == 0)
                            {
                            sq = "на оси y";
                         }

                    }
                }
            }


            bool ok = (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1 && y <= 0);
            Console.WriteLine($"Введенная вами точка лежит {sq}");
            Console.WriteLine();
            
            
            if (!ok) {
                Console.ForegroundColor = ConsoleColor.Red; 
                Console.WriteLine($"Результат {ok}");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("В область определения попадают только точки из 3 и 4 четверти, которые соответствуют формуле: x^2+y^2<=1");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green; 
                Console.WriteLine($"Результат {ok}");
                Console.ResetColor();

            }

            
            Console.WriteLine($"");


        }
    }
}
