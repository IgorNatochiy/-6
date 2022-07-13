using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool IsPalindrome(string s)
            {
                int i = 0, j = s.Length - 1;
                while (i < j)
                {
                    if (s[i] == ' ') i++;
                    else if (s[j] == ' ') j--;
                    else if (char.ToLower(s[i++]) != char.ToLower(s[j--])) return false;
                }
                return true;
            }
            Console.ReadKey();
        }
    }
}
