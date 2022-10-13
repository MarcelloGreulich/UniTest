using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqUniTestTest
{
    public class LinqUnit
    {
        static void Main(string[] args) { }

        public static List<string> ReturnDataCount(List<string> listOfString)
        {
            List<string> str = new List<string>();

            listOfString.Remove(listOfString.FirstOrDefault(i => i == "o"));

                foreach (var item in listOfString)
                {
                    str.Add(item);
                }
            return str;
        }
    }
}