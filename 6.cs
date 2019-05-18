using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Написать LINQ-запрос для поиска в массиве строк, начинающихся и заканчивающихся на одну и ту же букву. (0,5 балла)

            string[] worsdArray = { "Тест","тест","qwerty","Test", "qwerty", "test" ,"String s" };

            var selectedWorsd = from t in worsdArray
                                where t.ToUpper().StartsWith($"{t[0]}") && t.ToUpper().EndsWith($"{t[0]}") || t.ToLower().StartsWith($"{t[0]}") && t.ToLower().EndsWith($"{t[0]}")
                                select t; 

            foreach (string s in selectedWorsd)
                Console.WriteLine(s);
        }     
    }      
}

