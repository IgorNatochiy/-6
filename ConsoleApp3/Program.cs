using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();// Вводим строку
            string str2 = ""; // здесь будет наша перевернутая строка
            foreach (char 1; i >= 0; i--)
            {
                reverseStr += str[i]; // переворачиваем строку
            }

            if (str == reverseStr)
                Console.WriteLine("Введенная строка является палиндромом.");
            else
                Console.WriteLine("Введенная строка не является палиндромом.");
            Console.ReadKey();
        }
    }
}
