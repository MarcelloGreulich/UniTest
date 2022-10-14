using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqUniTestTest
{
    public class LinqUnit
    {
        static void Main(string[] args) { }

        public static List<int> Count(int[] intArr)
        {
            List<int> str = new List<int>();

            List<int> list = new List<int>();


            foreach (var item in intArr)
            {      
                list.Add(item);
            }

            list.Sort();
            list.Reverse();

            foreach (var n in list)
            {
                str.Add(n);
            }

            return str;
        }
    }
}