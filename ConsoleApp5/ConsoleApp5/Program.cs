using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums;
            int[,] numsQ;
            int[][] numsR;


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
            numsR = CreateaRaggedArray(5, 5);
            printRaggedArray(numsR);
            numsR = dellStrings(numsR);
            printRaggedArray(numsR);

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

        static void printRaggedArray(int[][] a)
        {
            Console.Write("Элементы массива:");
            Console.WriteLine();

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(String.Format("{0,3} ", a[i][j]));
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
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

        public static int[][] CreateaRaggedArray(int lg1, int lg2)
        {
            int[][] nums = new int[lg1][];
            Random rand = new Random();

            for (int i = 0; i < lg1; i++)
            {
                int lg3 = rand.Next(1, lg2);
                nums[i] = new int[lg3];
                for (int j = 0; j < lg3; j++)
                {
                    nums[i][j] = rand.Next(-100, 100);
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



        public static int[][] dellStrings(int[][] a)
        {
            int delStart = 0, delCount = 0, lg = 0;

            Console.Write("Введите строку с которой начать удаление = ");

            while ((!int.TryParse(Console.ReadLine(), out delStart)) || (delStart < 0) || (delStart > a.Length))
            {
                Console.WriteLine("Ошибка ввода");
            }

            Console.Write("Сколько строк удалить? = ");

            while ((!int.TryParse(Console.ReadLine(), out delCount)) || (delCount < 0) || (delCount > a.Length))
            {
                Console.WriteLine("Ошибка ввода");
            }

            lg = a.Length - (delCount + 1);

            int[][] nums = new int[lg][];

            int j = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (i < delStart || delStart + delCount < i)
                {
                    nums[j] = a[i];
                    j++;
                }

            }
            return nums;
        }
    }
}
