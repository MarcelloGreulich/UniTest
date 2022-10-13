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
            expected.Add("1 File(s) with frx Extension");
            expected.Add("1 File(s) with TXT Extension");
            expected.Add("1 File(s) with dbf Extension");
            expected.Add("1 File(s) with pdf Extension");
            expected.Add("1 File(s) with PDF Extension");
            expected.Add("1 File(s) with frt Extension");
            expected.Add("1 File(s) with xml Extension");
            expected.Add("2 File(s) with txt Extension");

            //Act
            List<string> str = LinqUnit.ReturnDataCount(arr1);

           //Assert
            CollectionAssert.AreEquivalent(str, expected);
            // CollectionAssert.AreEqual(expected, result);
        }
    }
}