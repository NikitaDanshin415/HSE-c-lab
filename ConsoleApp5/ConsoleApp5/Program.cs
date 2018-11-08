using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] nums;
            int[,] numsQ;
            int lg;
            Console.Write("Введите длину массива = ");
            while (!int.TryParse(Console.ReadLine(), out lg))
            {
                Console.Write("Ошибка, введите длину массива = ");
            }
            nums = CreateArray(lg);
            printArray(nums);
            int k;
            Console.Write("Введите K = ");
            while (!int.TryParse(Console.ReadLine(), out k))
            {
                Console.Write("Ошибка, введите K = ");
            }
            nums = dellElem(nums, k);
            printArray(nums);


            numsQ = CreateQuadArray(5, 6);
            printQuadArray(numsQ);
            numsQ = addColumnInStart(numsQ);
            printQuadArray(numsQ);

        }

        static void printArray(int[] a)
        {
            Console.Write("Элементы массива:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($" {a[i]}");
                Console.ResetColor();
            }
            Console.WriteLine();
        }

        static void printQuadArray(int[,] a)
        {
            Console.Write("Элементы массива:");
            Console.WriteLine();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(String.Format("{0,3} ", a[i, j]));
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static int[] CreateArray(int lg)
        {

            int[] nums = new int[lg];
            Random rand = new Random();

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(-100, 100);
            }
            return nums;
        }

        public static int[,] CreateQuadArray(int lg1, int lg2)
        {
            int[,] nums = new int[lg1, lg2];
            Random rand = new Random();

            for (int i = 0; i < lg1; i++)
            {
                for (int j = 0; j < lg2; j++)
                {
                    nums[i, j] = rand.Next(-100, 100);
                }
            }

            return nums;
        }

        static int[] dellElem(int[] a, int k)
        {
            if (!(a.Length < k))
            {
                int[] b = new int[(a.Length - k - 1) + 1];
                for (int i = 0; i < a.Length - k; i++)
                {
                    b[i] = a[i];
                }
                a = null;
                return b;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Элемента с индексом К не существует в данном массиве");
                Console.ResetColor();
                return a;
            }
        }

        public static int[,] addColumnInStart(int[,] a)
        {
            int lg1 = a.GetLength(0);    //строки i
            int lg2 = a.GetLength(1) + 1;  //столбцы j 
            int[,] nums = new int[lg1, lg2];
            Random rand = new Random();

            for (int i = 0; i < lg1; i++)
            {
                for (int j = 0; j < lg2; j++)
                {
                    if (j == 0)
                    {
                        nums[i, j] = rand.Next(-100, 100);
                    }
                    else
                    {
                        nums[i, j] = a[i, j - 1];
                    }
                }
            }
            return nums;
        }

        public static int[,] dellStrings(int[,] a, int k1, int k2)
        {
            int lg1 = a.GetLength(0) - (k2 - k1 + 1);    //строки i
            int lg2 = a.GetLength(1);  //столбцы j 

            int[,] nums = new int[lg1, lg2];
            Random rand = new Random();

            for (int i = 0; i < lg1; i++)
            {
                for (int j = 0; j < lg2; j++)
                {
                    if (i <= k1 && j >= k2)
                    {
                        nums[i, j] = a[i, j];
                    }
                }
            }
            return nums;
        }
    }
}

