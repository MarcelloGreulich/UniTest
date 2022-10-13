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
            List<string> listOfString = new List<string>();
            listOfString.Add("m");
            listOfString.Add("n");
            listOfString.Add("o");
            listOfString.Add("p");
            listOfString.Add("q");

            List<string> expected = new List<string>();
            expected.Add("m");
            expected.Add("n");
            expected.Add("p");
            expected.Add("q");


            //Act
            List<string> str = LinqUnit.ReturnDataCount(listOfString);

           //Assert
            CollectionAssert.AreEquivalent(str, expected);
            // CollectionAssert.AreEqual(expected, result);
        }
    }
}