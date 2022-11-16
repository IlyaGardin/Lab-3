using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace T3
{
    internal class LocalMethods
    {
        private static bool CheckingEmail(string email)
        {
            string pattern = @"^[0-9a-zA-Z](?:[\w\.\-]*[0-9a-zA-Z])?" + @"@" + @"(?:[0-9a-zA-Z](?:[\w\-]*[0-9a-zA-Z])?\.)+" +
                             @"[a-zA-Z]{2,6}$";
            return Regex.IsMatch(email, pattern);
        }
        //gardinilya@mail.gm.ru
        internal static void PrintCheckEmail(string email)
        {
            if (CheckingEmail(email) == true)
            {
                Console.WriteLine($"Введенная строка “{email}” является электронной почтой");
            }
            else
            {
                Console.WriteLine($"Введенная строка “{email}” НЕ является электронной почтой");
            }
        }

    }
}
