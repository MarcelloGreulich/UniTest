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
            List<string> list2 = new List<string>();
            var lis = from a in list
                      group a by a.Split('.')[1] into y
                      select y;

            string extension;
            int count;
            foreach (var a in lis)
            {   
                extension = a.Key;
                count = a.Count();
                list2.Add($"{count} File(s) with {extension} Extension");
            }
            return list2;
        }
    }
}
