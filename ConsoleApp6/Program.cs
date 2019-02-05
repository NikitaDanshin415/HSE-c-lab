using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите максимальное количество столбцов в массиве");
            //int countColumn;
            //while ((!int.TryParse(Console.ReadLine(), out countColumn)) || (countColumn <= 0))
            //{
            //    Console.WriteLine("Ошибка ввода. Введите целое положительное число.");
            //    Console.Write("Введите максимальное количество столбцов = ");
            //}
            //Console.WriteLine("Введите количество строк в массиве");

            //int countString;
            //while ((!int.TryParse(Console.ReadLine(), out countString)) || (countString <= 0))
            //{
            //    Console.WriteLine("Ошибка ввода. Введите целое положительное число.");
            //    Console.Write("Введите количество строк = ");
            //}

            //// Количество столбцов и строк


            //Console.WriteLine("Каким способом заполнить массив: \n 1)ДЧС \n 2)Ручками");
            //int methodCreate;
            //while ((!int.TryParse(Console.ReadLine(), out methodCreate)) || (methodCreate <= 0))
            //{
            //    Console.WriteLine("Ошибка ввода. Введите целое положительное число.");
            //    Console.Write("Введите количество строк = ");
            //}
            ////int[][] nums = new int[countString][];
            //char[][] charArr = new char[countString][];
            //switch (methodCreate)
            //{
            //    case 1:
            //        createRaggedArrayRandomMethod(countString, countColumn, charArr);
            //        break;
            //    case 2:
            //        createRaggedArrayHandMethod(countString, countColumn, charArr);
            //        break;
            //}
            //printRaggedArray(charArr);
            //charArr = dellLast(charArr);
            //printRaggedArray(charArr);

            //for", "if", "static,", "integer"
            //string test = Console.ReadLine();
            //string test = "if this static integer FOR INTeGER";
            //isKeyWord(test);
            bool go = true;

            while (go)
            {
                string selection = string.Empty;
                Console.WriteLine("Выберете задание: \n 1)Удаление строки из массива \n 2)Поиск ключевых слов c#");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Введите команду: ");
                Console.ResetColor();
                selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        dellFromString();
                        break;
                    case "2":
                        findKeyWords();
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
            char[] someCharArr = new char[] { 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            for (int i = 0; i < countString; i++)
            {
                int randCountString = rand.Next(1, countColumn + 1);
                charArr[i] = new char[randCountString];
                for (int j = 0; j < randCountString; j++)
                {
                    charArr[i][j] = someCharArr[rand.Next(0, someCharArr.Length - 1)];
                }
            }

        }

        public static void createRaggedArrayHandMethod(int countString, int countColumn, char[][] charArr)
        {

            for (int i = 0; i < countString; i++)
            {

                Console.WriteLine($"Введите строку {i + 1}");

                string str = Console.ReadLine();
                str = str.Replace(" ", string.Empty);
                while (str.Length > countColumn || str.Length == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка ввода. Введите строку длина которой не превышает {countColumn}");
                    Console.ResetColor();
                    str = Console.ReadLine();
                }

                charArr[i] = str.ToArray<char>();

            }

        }

        public static char[][] dellLast(char[][] charArr)
        {
            for (int i = 0; i < charArr.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < charArr[i].Length; j++)
                {
                    if (char.IsDigit(charArr[i][j]))
                    {
                        count++;
                        if (count == 3)
                        {
                            charArr = removeString(charArr, i);
                            Console.WriteLine($"Строка {i + 1} была удалена");
                            return charArr;
                        }
                    }
                }
            }
            return charArr;
        }


        public static char[][] removeString(char[][] array, int idx)
        {
            char[][] arrOut = new char[array.Length - 1][];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i != idx)
                    arrOut[k++] = array[i];
            }
            return arrOut;
        }

        public static void isKeyWord(string str)
        {
            string[] words = new string[] { "for", "if", "static", "integer","real","this","class" };
            str = str.ToLower();
            for (int i = 0; i < words.Length; i++)
            {              
                Regex regex = new Regex($@"(^|\b){words[i]}\b");
                MatchCollection matches = regex.Matches(str);
                Console.WriteLine($"{words[i]} встретилось {matches.Count} раз");
            }

        }


        public static void dellFromArray()
        {
            Console.WriteLine("Нажмите: \n 1-заполнить массив \n 2-распечатать массив \n 3-Удалить строку и массива \n 0-выход");
            int[] nums = null;
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
                        Console.WriteLine("Каким способом заполнить массив?");
                        string methodCreate = Console.ReadLine();
                        switch (methodCreate)
                        {
                            case "1":
                                createRaggedArrayRandomMethod(countString, countColumn, charArr);
                                break;
                            case "2":
                                createRaggedArrayHandMethod(countString, countColumn, charArr);
                                break;
                            case "0":                               
                                break;
                            default:
                                Console.WriteLine("Вы ввели неверную команду");
                                break;
                        }

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
    }
}
