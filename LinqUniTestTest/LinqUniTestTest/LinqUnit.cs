using System;
using System.Collections.Generic;

namespace LinqUniTestTest
{
    public class LinqUnit
    {
        static void Main(string[] args) { }

        public static List<string> ReturnDataCount(string[] list)
        {
            List<string> str = new List<string>();
            var set1 = new string[] { "X", "Y", "Z" };
            var set2 = new int[] { 1, 2, 3 };

            for (int t = 0; t < set1.Length; t++)
            {
                for (int i = 0; i < set2.Length; i++)
                {
                    string s = (set1[t] + Convert.ToString(set2[i]));
                    str.Add(s);
                }
            }
            return str;
        }
    }
}
