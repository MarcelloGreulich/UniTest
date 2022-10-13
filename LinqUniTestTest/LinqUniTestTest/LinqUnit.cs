using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqUniTestTest
{
    public class LinqUnit
    {
        static void Main(string[] args){}

        public static List<string> ReturnDataCount(string[] list)
        {
            List<string> str = new List<string>();

            var set1 = new string[] { "X", "Y", "Z" };
            var set2 = new int[] { 1, 2, 3 };
            for (int i = 0; i < set1.Length; i++)
            {
                string s = (set1[i] + Convert.ToString(set2[i]));
                str.Add(s);
            }
            return str;
        }
    }
}
