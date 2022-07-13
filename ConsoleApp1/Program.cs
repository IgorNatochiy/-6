using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cлово: ");
            string s = Console.ReadLine();
            if (ItIsPalindrom(s))
                Console.Write("это - палиндром ");
            else
                Console.Write("не палиндром ");
            Console.ReadKey();
        }
        // Проверка. Возврат ДА/НЕТ
        static bool ItIsPalindrom(string s)
        {
            bool b = true;
            for (int k = 0; k < s.Length / 2; k++)
            {
                if (s[k] != s[s.Length - 1 - k])
                    b = false;
            }
            return b;
        }
    }
}
