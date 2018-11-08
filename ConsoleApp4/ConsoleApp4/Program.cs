using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] nums = null;
            Console.WriteLine("Нажмите: \n 1-заполнить массив \n 2-распечатать массив \n 3-Удалить четные элементы \n 4-Поменять местами мин и макс \n 5-Найти отр.элемент \n 6-Сортировка \n 7-Добавить элементы \n 0-выход");
            string selection = string.Empty;
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
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Массив пустой, для заполнения массива выполните команду 1");
                            Console.ResetColor();
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
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Массив пустой, для заполнения массива выполните команду 1");
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            nums = chentNumsArray(nums);
                            printArray(nums);
                            break;
                        }
                    case "4":
                        if (nums == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Массив пустой, для заполнения массива выполните команду 1");
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            SwapMaxAndMin(nums);
                            printArray(nums);
                            break;
                        }
                    case "5":
                        if (nums == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Массив пустой, для заполнения массива выполните команду 1");
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            findNegative(nums);
                            break;
                        }
                    case "6":
                        if (nums == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Массив пустой, для заполнения массива выполните команду 1");
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            SelectionSort(nums);
                            printArray(nums);
                            break;
                        }
                    case "7":
                        if (nums == null)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Массив пустой, для заполнения массива выполните команду 1");
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            nums = addElem(nums);
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


        static int[] chentNumsArray(int[] a)
        {
            if (a.Length % 2 == 0)
            {
                int[] b = new int[a.Length / 2];
                int j = 0;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        b[j] = a[i];
                        j++;
                    }
                }
                return b;
            }
            else
            {
                int[] b = new int[(a.Length / 2) + 1];
                int j = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        b[j] = a[i];
                        j++;
                    }
                }
                return b;
            }
        }

        static int[] addElem(int[] a)
        {
            int b;
            Console.Write("Введите количество элементов = ");
            while ((!int.TryParse(Console.ReadLine(), out b)) || (b <= 0))
            {
                Console.WriteLine("Длина должна быть целым положительынм числом");
            }

            Random rand = new Random();
            int[] c = new int[a.Length + b];
            for (int i = 0; i < a.Length + b; i++)
            {
                if (i <= a.Length - 1)
                {
                    c[i] = a[i];
                }
                else
                {
                    c[i] = rand.Next(-100, 100);
                }
            }
            return c;
        }

        public static void SwapMaxAndMin(int[] a)
        {
            if (a.Length == 0)
                return;

            var min = a.Min();
            var max = a.Max();

            if (min == max)
                return;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == min)
                    a[i] = max;
                else if (a[i] == max)
                    a[i] = min;
            }
        }

        public static void findNegative(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Кол-во сравнений:{i + 1}");
                    Console.ResetColor();
                    break;
                }
            }
        }

        public static void SelectionSort(int[] arr)
        {
            int min, temp;
            int length = arr.Length;

            for (int i = 0; i < length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
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
    }
}
