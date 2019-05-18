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
            //Записать в двоичный файл простые числа, не превышающие число 100. (1 балл)

            //Для выполнения задачи нужны админские права для создания файлов, в классе этих прав не было, поэтому не смог протестить :(
            string digits = "";
            
            for (int i = 2; i <= 100; i++)
            {
                if (isSimple(i))
                {        
                    digits += i; 
                }
            }
            
           //Создаем или открываем файл index.txt на диске С и записываем туда строку с простыми числами
            using (FileStream fstream = new FileStream(@"C:\index.txt", FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(digits);
                fstream.Write(array, 0, array.Length);
                Console.WriteLine("Текст записан в файл");
            }
        
           

            
        }
        //метод который определяет простое число или нет
        private static bool isSimple(int N)
        {
            //чтоб убедится простое число или нет достаточно проверить не делитсья ли 
            //число на числа до его половины
            for (int i = 2; i < (int)(N / 2); i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }
    }

        
}

