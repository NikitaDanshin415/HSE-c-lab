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
            //int[][] nums = new int[countString][];
            char[][] charArr = new char[countString][];
            switch (methodCreate)
            {
                case 1:
                    createRaggedArrayRandomMethod(countString, countColumn, charArr);
                    break;
                case 2:
                    createRaggedArrayHandMethod(countString, countColumn, charArr);
                    break;
            }
            printRaggedArray(charArr);


        }
        public static void printEmptyArrayError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Массив пустой, для заполнения массива выполните команду 1");
            Console.ResetColor();
        }
        static void printRaggedArray(char[][] a)
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
        public static void createRaggedArrayRandomMethod(int countString, int countColumn, char[][] charArr)
        {

            Random rand = new Random();
            char[] someCharArr = new char[] {'q','w','e','r','t','y','u', 'i', 'o', 'p', 'a', 's', 'd', 'f', '1','2','3','4','5','6','7','8','9','0'} ;

            for (int i = 0; i < countString; i++)
            {
                int randCountString = rand.Next(1, countColumn+1);
                charArr[i] = new char[randCountString];
                for (int j = 0; j < randCountString; j++)
                {
                    charArr[i][j] = someCharArr[rand.Next(0, someCharArr.Length-1)];
                }
            }

        }

        public static void createRaggedArrayHandMethod(int countString, int countColumn, char[][] charArr)
        {

            for (int i = 0; i < countString; i++)
            {
               
                Console.WriteLine($"Введите строку {i+1}");

                string str = Console.ReadLine();
                str = str.Replace(" ", string.Empty);
                while (str.Length>countColumn || str.Length==0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Ошибка ввода. Введите строку длина которой не превышает {countColumn}");
                            Console.ResetColor();
                            str = Console.ReadLine();
                        }
                
                charArr[i] = str.ToArray<char>();

            }

        }
    }

}
