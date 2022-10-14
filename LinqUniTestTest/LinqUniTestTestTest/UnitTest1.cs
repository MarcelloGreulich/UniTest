using Microsoft.VisualStudio.TestPlatform.TestHost;
using LinqUniTestTest;
using FluentAssertions;

namespace LinqUniTestTestTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };

            List<int> expected = new List<int>();
            expected.Add(81);
            expected.Add(64);
            expected.Add(36);
            expected.Add(25);

            //Act
            List<int> intArr = LinqUnit.SquareNo(arr1);

            //Assert

            intArr.Should().BeEquivalentTo(expected);

        }
    }
}