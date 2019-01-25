using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите максимальное количество столбцов в массиве");
            int countColumn;
            while ((!int.TryParse(Console.ReadLine(), out countColumn)) || (countColumn <= 0))
            {
                Console.WriteLine("Ошибка ввода. Введите целое положительное число.");
                Console.Write("Введите максимальное количество столбцов = ");
            }
            Console.WriteLine("Введите количество строк в массиве");

            int countString;
            while ((!int.TryParse(Console.ReadLine(), out countString)) || (countString <= 0))
            {
                Console.WriteLine("Ошибка ввода. Введите целое положительное число.");
                Console.Write("Введите количество строк = ");
            }

            // Количество столбцов и строк


            Console.WriteLine("Каким способом заполнить массив: \n 1)ДЧС \n 2)Ручками");
            int methodCreate;
            while ((!int.TryParse(Console.ReadLine(), out methodCreate)) || (methodCreate <= 0))
            {
                Console.WriteLine("Ошибка ввода. Введите целое положительное число.");
                Console.Write("Введите количество строк = ");
            }
            int[][] nums = new int[countColumn][];
            switch (methodCreate)
            {
                case 1:                   
                    createRaggedArrayRandomMethod(countColumn, countString, nums);
                    break;
                case 2:                   
                    createRaggedArrayHandMethod(countColumn, countString, nums);
                    break;
            }
            printRaggedArray(nums);


        }
        public static void printEmptyArrayError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Массив пустой, для заполнения массива выполните команду 1");
            Console.ResetColor();
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
        public static void createRaggedArrayRandomMethod(int lg1, int lg2, int[][] nums)
        {

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

        }

        public static void createRaggedArrayHandMethod(int lg1, int lg2, int[][] nums)
        {

            for (int i = 0; i < lg1; i++)
            {
                int strLen;
                Console.WriteLine($"Введите количество элементов в строке {i + 1}");
                while ((!int.TryParse(Console.ReadLine(), out strLen)) || (strLen <= 0) || (strLen > lg2))
                {
                    Console.WriteLine($"Ошибка ввода. Введите целое положительное число, не превышающее {lg2}");
                    Console.Write($"Введите количество элементов в строке {i + 1}");
                }

                
                nums[i] = new int[strLen];
                for (int j = 0; j < strLen; j++)
                {
                    Console.WriteLine($"Введите значение элемента {i}:{j}");
                    while ((!int.TryParse(Console.ReadLine(), out nums[i][j])))
                    {
                        Console.WriteLine($"Ошибка ввода. Введите целое положительное число, не превышающее {lg2}");
                        Console.WriteLine($"Введите значение элемента {i}:{j}");
                    }
                  
                }
            }

     
        }
    }
  
}
