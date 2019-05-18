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

            //Дан двумерный массив (m x n). Определить количество различных элементов в нем. (1 балл)


            int lg1, lg2;

            Console.Write("Введите количество строк в массиве = ");
            while ((!int.TryParse(Console.ReadLine(), out lg1)) || (lg1 < 0))
            {
                Console.WriteLine("Ошибка ввода, число строк должно быть целочисленным положительным числом");
                Console.Write("Попробуйте еще раз, количество строк = ");
            };

            Console.Write("Введите количество столбцов в массиве = ");
            while ((!int.TryParse(Console.ReadLine(), out lg2)) || (lg2 < 0))
            {
                Console.WriteLine("Ошибка ввода, число столбцов должно быть целочисленным положительным числом");
                Console.Write("Попробуйте еще раз, количество столбцов = ");
            };

            //Создаем массив с рандомными символами и список в который будем добавлять уникальные символы
            char[,] numsQ = CreateQuadArray(lg1, lg2);
            List<char> unicChars = new List<char>();

            //Печать созданного массива
            printQuadArray(numsQ);

            //Бежим по массиву и проверяем наличие каждого элемента в списке, в случае если элемента нет в списке, добавляем
            //Если элемент есть в списке, то идем далее
            for (int i = 0; i < lg1; i++)
            {
                for (int j = 0; j < lg2; j++)
                {
                    if (unicChars.IndexOf(numsQ[i, j]) == -1)
                    {
                        unicChars.Add(numsQ[i, j]);
                    }
                }
            }

            //Вывод количества уникальных элементов в массиве
            Console.WriteLine($"Массив состоит из {unicChars.LongCount()} разных элементов");

            //Вывод списка с этими уникальными элементами
            Console.Write("Список элементов : ");
            unicChars.ForEach(delegate (Char unic)
            {
                Console.Write(unic + " ");
            });
            Console.WriteLine();
        }


        /// <summary>
        /// Функция для создания рандомного двумерного массива символов
        /// </summary>
        /// <param name="lg1">Количество строк в массиве</param>
        /// <param name="lg2">Количество столбцов в массиве</param>
        /// <returns></returns>
        public static char[,] CreateQuadArray(int lg1, int lg2)
        {
            char[,] nums = new char[lg1, lg2];
            Random rand = new Random();

            char[] someCharArr = new char[] { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };


            for (int i = 0; i < lg1; i++)
            {
                for (int j = 0; j < lg2; j++)
                {
                    nums[i, j] = someCharArr[rand.Next(0, someCharArr.Length - 1)];
                }
            }

            return nums;
        }

        /// <summary>
        /// Функция для печати двумерного массива символов
        /// </summary>
        /// <param name="a">Массив символов</param>
        static void printQuadArray(char[,] a)
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
    }
}
