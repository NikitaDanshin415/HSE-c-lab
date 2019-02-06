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
                writeMenu("Выберете задание: \n 1)Удаление строки из массива \n 2)Поиск ключевых слов c# \n 3)Отчистить консоль");
                writeMenu("Введите команду: ");
                selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        dellFromArray();
                        break;
                    case "2":
                        findKeyWords();
                        break;
                    case "3":
                        Console.Clear();
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
            writeMenu("Элементы массива:");
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

                writeMenu($"Введите строку {i + 1}");

                string str = Console.ReadLine();
                str = str.Replace(" ", string.Empty);
                while (str.Length > countColumn || str.Length == 0)
                {
                    writeError($"Ошибка ввода. Введите строку длина которой не превышает {countColumn}");
                    writeMenu($"Введите строку {i + 1}");
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
                            writeSuc($"Строка {i + 1} была удалена");
                            return charArr;
                        }

                    }
                }
            }
            writeError($"В массиве нет строк содержащих 3 и более чисел");
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
            string[] words = new string[] { "for", "if", "static", "integer", "real", "this", "class" };
            str = str.ToLower();
            bool isset = false;
            for (int i = 0; i < words.Length; i++)
            {
                Regex regex = new Regex($@"(^|\b){words[i]}\b");
                MatchCollection matches = regex.Matches(str);
                if (matches.Count > 0)
                {
                    writeSuc($"{words[i]} встретилось {matches.Count} раз");
                    isset = true;
                }
            }
            if (!isset)
            {
                writeError("В введенной строке нет ключевых слов c# (for , if , static, integer, real, this, class)");
            }

        }

        public static void writeError(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();

        }

        public static void writeMenu(string text)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(text);
            Console.ResetColor();

        }

        public static void writeSuc(string text)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(text);
            Console.ResetColor();

        }

        public static void dellFromArray()
        {
            writeMenu("Нажмите: \n 1)заполнить массив \n 2)распечатать массив \n 3)Удалить строку и массива \n 0)выход");
            char[][] charArr = null;
            string selection = string.Empty;
            while (selection != "0")
            {
                writeMenu("Введите команду: ");
                selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        writeMenu("Введите максимальное количество столбцов в массиве");
                        int countColumn;
                        while ((!int.TryParse(Console.ReadLine(), out countColumn)) || (countColumn <= 0))
                        {
                            writeError("Ошибка ввода. Введите целое положительное число.");
                            writeMenu("Введите максимальное количество столбцов = ");
                        }

                        writeMenu("Введите количество строк в массиве");
                        int countString;
                        while ((!int.TryParse(Console.ReadLine(), out countString)) || (countString <= 0))
                        {
                            writeError("Ошибка ввода. Введите целое положительное число.");
                            writeMenu("Введите количество строк = ");
                        }


                        charArr = new char[countString][];
                        writeMenu("Каким способом заполнить массив? \n 1)ДЧС \n 2)В ручную");
                        string methodCreate = Console.ReadLine();
                        switch (methodCreate)
                        {
                            case "1":
                                createRaggedArrayRandomMethod(countString, countColumn, charArr);
                                printRaggedArray(charArr);
                                break;
                            case "2":
                                createRaggedArrayHandMethod(countString, countColumn, charArr);
                                printRaggedArray(charArr);
                                break;
                            case "0":
                                break;
                            default:
                                writeError("Вы ввели неверную команду");
                                writeMenu("Каким способом заполнить массив? \n 1)ДЧС \n 2)В ручную");
                                break;
                        }
                        writeMenu("Нажмите: \n 1)заполнить массив \n 2)распечатать массив \n 3)Удалить строку и массива \n 0)выход");
                        break;
                    case "2":
                        if (charArr == null)
                        {
                            printEmptyArrayError();
                            break;
                        }
                        else
                        {
                            printRaggedArray(charArr);
                            writeMenu("Нажмите: \n 1)заполнить массив \n 2)распечатать массив \n 3)Удалить строку и массива \n 0)выход");
                            break;
                        }

                    case "3":
                        if (charArr == null)
                        {
                            printEmptyArrayError();
                            break;
                        }
                        else
                        {
                            charArr = dellLast(charArr);
                            printRaggedArray(charArr);
                            writeMenu("Нажмите: \n 1)заполнить массив \n 2)распечатать массив \n 3)Удалить строку и массива \n 0)выход");
                            break;
                        }
                    case "0":
                        break;
                    default:
                        writeError("Вы нажали неизвестную команду");
                        writeMenu("Нажмите: \n 1)заполнить массив \n 2)распечатать массив \n 3)Удалить строку и массива \n 0)выход");
                        break;
                }
            }
        }

        public static void findKeyWords()
        {
            writeMenu("Нажмите: \n 1)Ввести строку \n 2)распечатать строку \n 3)Найти слова c# \n 0)выход");
            string userStr = null;
            string selection = string.Empty;
            while (selection != "0")
            {
                writeMenu("Введите команду: ");
                selection = Console.ReadLine();
                switch (selection)
                {
                    case "1":
                        writeMenu("Введите строку");
                        userStr = Console.ReadLine();
                        writeMenu("Нажмите: \n 1)Ввести строку \n 2)распечатать строку \n 3)Найти слова c# \n 0)выход");
                        break;
                    case "2":
                        writeSuc("Вы ввели: " + userStr);
                        writeMenu("Нажмите: \n 1)Ввести строку \n 2)распечатать строку \n 3)Найти слова c# \n 0)выход");
                        break;
                    case "3":
                        isKeyWord(userStr);
                        writeMenu("Нажмите: \n 1)Ввести строку \n 2)распечатать строку \n 3)Найти слова c# \n 0)выход");
                        break;
                    case "0":
                        break;
                    default:
                        writeError("Вы ввели неизвестную команду");
                        writeMenu("Нажмите: \n 1)Ввести строку \n 2)распечатать строку \n 3)Найти слова c# \n 0)выход");
                        break;

                }
            }
        }
    }
}
