using Microsoft.VisualStudio.TestPlatform.TestHost;
using LinqUniTestTest;

namespace LinqUniTestTestTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string[] arr1 = { "aaa.frx", "bbb.TXT", "xyz.dbf", "abc.pdf", "aaaa.PDF", "xyz.frt", "abc.xml", "ccc.txt", "zzz.txt" };

            List<string> expected = new List<string>();
            expected.Add("X1");
            //expected.Add("X2");
            //expected.Add("X3");
            //expected.Add("Y1");
            expected.Add("Y2");
            //expected.Add("Y3");
            //expected.Add("Z1");
            //expected.Add("Z2");
            expected.Add("Z3");


            //Act
            List<string> str = LinqUnit.ReturnDataCount(arr1);

           //Assert
            CollectionAssert.AreEquivalent(str, expected);
            // CollectionAssert.AreEqual(expected, result);
        }
    }
}