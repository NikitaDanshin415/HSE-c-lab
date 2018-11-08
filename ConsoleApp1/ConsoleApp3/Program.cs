using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Даньшин Никита, ПИ-18У, Вариант №6, Задание №3");
            Console.WriteLine();           

            double a = 100, b = 0.001;
            double res1 = (Math.Pow(a - b, 3) - (Math.Pow(a, 3) + 3 * a * Math.Pow(b, 2))) / (-3 * Math.Pow(a, 2) * b - Math.Pow(b, 3));
            Console.WriteLine($"double = {res1}");


            float fa = 100, fb = 0.001f;
            float res2 = (((float)Math.Pow((fa - fb), 3)) - ((float)Math.Pow((fa), 3) + 3 * fa * (float)Math.Pow((fb), 3)))/ (-3 * (float)Math.Pow(fa, 2) * fb - (float)Math.Pow(fb, 3)); 
            Console.WriteLine($"float = {res2}");
        }
    }
}
