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
            bool go = true;
           
            while (go)
            {
                string selection = string.Empty;
                Console.WriteLine("Нажмите: \n 1-Работа с одномерными массивами \n 2-Работа с двумерными массивамив \n 3-Работа с рваными массивами \n 0-выход");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Введите команду: ");
                Console.ResetColor();
                selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        simpleArray();
                        break;
                    case "2":
                        quadArray();
                        break;
                    case "3":
                        raggedArray();
                        break;
                    case "0":
                        go = false;
                        break;
                }
            }
        }

        public static void printEmptyArrayError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Массив пустой, для заполнения массива выполните команду 1");
            Console.ResetColor();
        }

        static void simpleArray()
        {
            string selection = string.Empty;


            Console.WriteLine("Нажмите: \n 1-заполнить массив \n 2-распечатать массив \n 3-Удалить элементы массива \n 0-выход");
            int[] nums = null;
            while (selection != "0")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Введите команду: ");
                Console.ResetColor();
                selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        Console.Write("Введите длину массива = ");
                        int lg;
                        while (!int.TryParse(Console.ReadLine(), out lg))
                        {
                            Console.Write("Ошибка, введите длину массива = ");
                        }
                        nums = CreateArray(lg);
                        printArray(nums);
                        break;
                    case "2":
                        if (nums == null)
                        {
                            printEmptyArrayError();
                            break;
                        }
                        else
                        {
                            printArray(nums);
                            break;
                        }
                    case "3":
                        if (nums == null)
                        {
                            printEmptyArrayError();
                            break;
                        }
                        else
                        {
                            nums = dellElem(nums);
                            printArray(nums);
                            break;
                        }
                    case "0":
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы нажали неизвестную команду");
                        Console.ResetColor();
                        break;
                }
            }
        }

        static void quadArray()
        {
            string selection = string.Empty;
            Console.WriteLine("Нажмите: \n 1-заполнить массив \n 2-распечатать массив \n 3-Добавить столбец в начало \n 0-выход");
            int[,] numsQ = null;
            while (selection != "0")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Введите команду: ");
                Console.ResetColor();
                selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":

                        int strings,columns;
                        Console.Write("Введите количество строк массива = ");
                        while (!int.TryParse(Console.ReadLine(), out strings))
                        {
                            Console.Write("Ошибка ввода, введите целочисленное число = ");
                        }

                        Console.Write("Введите количество столбцов массива = ");
                        while (!int.TryParse(Console.ReadLine(), out columns))
                        {
                            Console.Write("Ошибка ввода, введите целочисленное число = ");
                        }
                        numsQ = CreateQuadArray(strings,columns);
                        printQuadArray(numsQ);
                        break;
                    case "2":
                        if (numsQ == null)
                        {
                            printEmptyArrayError();                         
                            break;
                        }
                        else
                        {
                            printQuadArray(numsQ);
                            break;
                        }
                    case "3":
                        if (numsQ == null)
                        {
                            printEmptyArrayError();
                            break;
                        }
                        else
                        {
                            numsQ = addColumnInStart(numsQ);
                            printQuadArray(numsQ);
                            break;
                        }
                    case "0":
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы нажали неизвестную команду");
                        Console.ResetColor();
                        break;
                }
            }
        }

        static void raggedArray()
        {

            string selection = string.Empty;
            Console.WriteLine("Нажмите: \n 1-заполнить рваный массив \n 2-распечатать рваный массив \n 3-Удалить строки \n 0-выход");
            int[][] numsR = null;
            while (selection != "0")
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Введите команду: ");
                Console.ResetColor();
                selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":

                        int strings, columns;
                        Console.Write("Введите количество строк массива = ");
                        while (!int.TryParse(Console.ReadLine(), out strings))
                        {
                            Console.Write("Ошибка ввода, введите целочисленное число = ");
                        }

                        Console.Write("Введите количество столбцов массива = ");
                        while (!int.TryParse(Console.ReadLine(), out columns))
                        {
                            Console.Write("Ошибка ввода, введите целочисленное число = ");
                        }
                        numsR = CreateaRaggedArray(strings, columns);
                        printRaggedArray(numsR);
                        break;
                    case "2":
                        if (numsR == null)
                        {
                            printEmptyArrayError();
                            break;
                        }
                        else
                        {
                            printRaggedArray(numsR);
                            break;
                        }
                    case "3":
                        if (numsR == null)
                        {
                            printEmptyArrayError();
                            break;
                        }
                        else
                        {
                            numsR = dellStrings(numsR);
                            printRaggedArray(numsR);
                            break;
                        }
                    case "0":
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Вы нажали неизвестную команду");
                        Console.ResetColor();
                        break;
                }
            }
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

        static int[] dellElem(int[] a)
        {
            int count;
            Console.WriteLine("Какое количество элементов с конца вы хотите удалить?");
            while (!int.TryParse(Console.ReadLine(), out count))
            {
                Console.Write("Введите целочисленное число");
            }

            if (!(a.Length < count))
            {
                int[] b = new int[(a.Length - count - 1) + 1];
                for (int i = 0; i < a.Length - count; i++)
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
