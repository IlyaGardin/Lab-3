using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    internal class LocalMethods
    {      

        internal static bool IsStringPalindrome(string str)
        {             
            StringBuilder arr = new StringBuilder();
            foreach (var i in str)
            {
                if (char.IsLetter(i))
                {
                    arr.Append(i);
                }
            }
            char[] tempArr = arr.ToString().ToCharArray();
            Array.Reverse(tempArr);
            return new string(tempArr) == arr.ToString();
        }
        internal static void PrintIsPalindrome(string str)
        {
            if (IsStringPalindrome(str) == true)
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является палиндромом");
            }
        }
    }
}
