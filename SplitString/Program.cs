using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Написать метод GetFullName(string firstName, string lastName, string
//patronymic), принимающий на вход ФИО в разных аргументах и возвращающий
//объединённую строку с ФИО. Используя метод, написать программу, выводящую в консоль
//3–4 разных ФИО.

namespace SplitString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = {"Иванов", "Петров", "Сидоров", "Соколов" };
            string[] last = { "Евгений", "Александр", "Петр", "Алексей" };
            string[] past = { "Александрович", "Алексеевич", "Евгеньевич", "Петрович" };
            for (int i = 0; i<first.Length; i++)
            {
                string firstName = first[i];
                string lastName = last[i];
                string patronymic = past[i];

                GetFullName(firstName, lastName, patronymic);
            }
        }
        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            Console.WriteLine("{0} {1} {2}", firstName, lastName, patronymic);
            return "";
        }
    }
}
