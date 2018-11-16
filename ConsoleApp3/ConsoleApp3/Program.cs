using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            float b = 2, a = 1, k = 10;

            for (double x = 1; x <= 2; x += (b - a) / k)
            {
                Console.Write($"X = {x} |");
                double s = 0;

                for (int n = 0; n <= 15; n++)
                {
                    s += Math.Pow(x, n) / (int)fa(n);
                }
                Console.Write($"SN = {s} |");


                Console.Write($"Y = {Math.Pow(Math.E, x)} |");

                const double eps = 0.0001;
                double se = 1;
                double fact2 = 1;
                int m = 1;
                double currentTerm = 1;

                while (currentTerm > eps)
                {
                    fact2 = fa(m);
                    currentTerm = Math.Pow(x, m) / (int)fa(m);
                    se = se + currentTerm;
                    m++;
                }

                Console.Write($"SE = {se} |");
                Console.WriteLine();


            }

        }

        static double fa(double x)
        {
            double result = 1;
            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
