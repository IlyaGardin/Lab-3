using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace T5
{
    internal class LocalMethods
    {
        private static MatchCollection SearchDates(string line)
        {
            string pattern = @"(?<day>(?:[0][1-9]|[1-2][0-9]|[3][0-1]))-" +
                             @"(?<month>(?:[0][1-9]|[1][0-2]))-" +
                             @"(?<year>[1-9][0-9]{3})";
            Regex regex = new Regex(pattern);
            
            return regex.Matches(line); 
        }
        internal static void WriteFoundDates(string line)
        {
            MatchCollection matches = SearchDates(line);
            string[] dates = new string[matches.Count];

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Groups["day"].Value + " " + item.Groups["month"].Value + " " + item.Groups["year"].Value);
                Console.Write($"где день = {item.Groups["day"].Value}");
                Console.Write($", месяц = {item.Groups["month"].Value}");
                Console.Write($", год = {item.Groups["year"].Value}\n");
            }
            
            
        }
    
    }
}
