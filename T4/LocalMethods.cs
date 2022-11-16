using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace T4
{
    internal class LocalMethods
    {
        internal static string ReplaceTagsByRegular(string s)
        {
            string pattern = @"<[^>]*>";
            string target = "_";
            //<b>Это</b> текст <i>с</i> <font color=”red”>HTML</font> кодами
            Regex regex = new Regex(pattern);

            return regex.Replace(s, target);
        }
        internal static string ReplaceTagsWithoutRegular(string s)
        {
            StringBuilder builder_s = new StringBuilder();
            int counterIndx = 0;
            int indexFirst;
            int indexLast;
            while (true)
            {
                indexFirst = s.IndexOf("<", counterIndx);
                indexLast = s.IndexOf(">", counterIndx);
                if (indexFirst == -1 || indexLast == -1)
                {
                    builder_s.Append(s.Substring(counterIndx, s.Length - counterIndx));
                    break;
                }

                builder_s.Append(s.Substring(counterIndx, indexFirst - counterIndx) + "_");
                counterIndx = indexLast + 1;
            }

            return builder_s.ToString();
        }
    }
}
