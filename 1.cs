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
			//Проверить принадлежит ли точка выделенной области
            float x, y;

            Console.Write("Введите число X  = ");

            while ((!float.TryParse(Console.ReadLine(), out x)))
            {
                Console.WriteLine("Ошибка ввода, число X должно быть числом, дробные числа вводятся через запятую");
                Console.Write("Попробуйте еще раз, X = ");
            };

            Console.Write("Введите число Y  = ");
            while ((!float.TryParse(Console.ReadLine(), out y)))
            {
                Console.WriteLine("Ошибка ввода, число X должно быть числом, дробные числа вводятся через запятую");
                Console.Write("Попробуйте еще раз, Y = ");
            };
       

            if (y >= 0 && y <= 1 && x >=1 && x<=2)
            {
                Console.WriteLine("Пренадлежит");
            }else if (y >= 0 && x <= -1 && x >= -2)
            {
                Console.WriteLine("Пренадлежит");
            }else if( y >= 1 && y <= 2 && x <= 2 && x >= -2)
            {
                Console.WriteLine("Пренадлежит");
            }else 
            {
                Console.WriteLine("Не Пренадлежит");
            }


        }
    }
}
