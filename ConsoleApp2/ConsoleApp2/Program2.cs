using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int i = 1, el = 0,n;
            string q;
            Console.Write($"{i} элемент последовательности = ");
            while (( q = Console.ReadLine())!="0")
            {

                if (!int.TryParse(q, out n)) {
                    Console.ForegroundColor = ConsoleColor.Red;                
                    Console.WriteLine("Ошибка");
                    Console.ResetColor();
                    Console.Write($"{i} элемент последовательности = ");
                }
                else
                {
                    if( n % 2 == 0)
                    {
                        el++;                                           
                    }
                    i++;
                    Console.Write($"{i} элемент последовательности = ");
                }              
            };      
            Console.WriteLine($"Четных элементов = {el} ");
           
        }

    }
}
