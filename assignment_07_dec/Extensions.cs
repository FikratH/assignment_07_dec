using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_07_dec
{
    internal static class Extensions
    {
        public static string CustomContains(this string str,string checkedStr)
        { 
            string strLow = str.ToLower(); //hello world
            string checkedStrLow = checkedStr.ToLower(); //rld
            int checkIndex = 0;
            int i;
            for (i = 0; i < strLow.Length; i++)
            {
                if (strLow[i] == checkedStrLow[checkIndex])
                {
                    if (checkIndex == checkedStrLow.Length - 1)
                    {
                        return $"The sentence contains '{checkedStr}'.";
                    }
                    checkIndex++;
                }
                else
                {
                    checkIndex = 0;
                    i--;
                }
            }
            return $"The sentence does NOT contain '{checkedStr}'."; ;
        }
    }
}
