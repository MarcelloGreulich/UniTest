using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqUniTestTest
{
    public class LinqUnit
    {
        static void Main(string[] args) { }

        public static List<int> SquareNo(int[] intArr)
        {
            List<int> str = new List<int>();

            var sqNo = from int Number in intArr
                       let SqrNo = Number * Number
                       where SqrNo > 20
                       select SqrNo;

            foreach (var a in sqNo)
                str.Add(a);
            return str;
        }
    }
}