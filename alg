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
            float[] works = {5,4,3,1,2,3,5,3,7};
            int empliys = 6; //количество работников

            int work_id = 0; //номер работы

            float remain = 7; // количество работы для 1 работника
           
            for (int i = 0; i < empliys; i++)
            {
                if (works[work_id] > 0)
                {
                    Console.Write($"Работник {i+1} выполнил:");
                    while(remain > 0) // вычитаем из remain работы и зануляем работы
                    {
                        if(works[work_id] < remain)
                        {
                            Console.Write($" | Работу {work_id+1} = {works[work_id]}");
                            remain -= works[work_id];
                            works[work_id] = 0;
                            work_id++;
                        }else
                        {
                            works[work_id] -= remain;
                            remain = 0;
                            Console.Write($" | Работу {work_id + 1} = {remain}");
                        }
                    }
                    remain = 7;
                    Console.WriteLine();
                }
            }

        }
    }
}
