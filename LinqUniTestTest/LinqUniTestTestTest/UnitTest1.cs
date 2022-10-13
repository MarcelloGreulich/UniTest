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
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] expected = new int[] { 2, 4, 6, 8, 10 };
            List<int> result = LinqUnit.DevideByTwo(arr);
            CollectionAssert.AreEquivalent(expected, result);
           // CollectionAssert.AreEqual(expected, result);
        }
    }
}