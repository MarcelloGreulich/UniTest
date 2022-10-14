using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqUniTestTest
{
    public class LinqUnit
    {
        static void Main(string[] args) { }

        public static List<string> Count(int[] intArr)
        {
            List<string> str = new List<string>();

            var num = from int Number in intArr
                      group Number by Number into n
                      select n;
            foreach (var a in num)
            {
                str.Add($"Number {a.Key} ist {a.Count()} vorhanden");
            }
            return str;
        }
    }
}