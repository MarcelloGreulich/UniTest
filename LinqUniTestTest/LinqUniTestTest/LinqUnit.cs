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

        public static List<int> DevideByTwo(int[] list)
        {
            List<int> li = new List<int>();
            for (int i = 1; i < list.Length; i++)
            {
                if (list[i] % 2 == 0)
                {
                    li.Add(list[i]);
                    Console.WriteLine(list[i]);

                }
            }
            return li;
        }
    }
}
