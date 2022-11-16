using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    internal class LocalMethods
    {
        public static double GetAverageWordLength(string str)
        {
            string[] words = str.Split(new[] { '.','?','!', ':', ';', ',', '-','(', ')', '[', ']','{','}',' '});

            double sumWords = 0;
            foreach (var item in words)
            {               
               sumWords += item.Length;                
            }
                       
            return sumWords / (words.Length - SearchForEmptyWords(words));
            
            
        }

        private static uint SearchForEmptyWords(string[] str)
        {
            uint count = 0;
            for (int i= 0; i < str.Length; i++)
            {
                if(str[i].Length == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
