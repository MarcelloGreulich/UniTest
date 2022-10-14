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
            int[] arr1 = new int[] {12,54,516,31,315,78};

            List<int> expected = new List<int>();
            expected.Add(516);
            expected.Add(315);
            expected.Add(78);
            expected.Add(54);
            expected.Add(31);
            expected.Add(12);

            //Act
            List<int> intArr = LinqUnit.Count(arr1);

            //Assert

            intArr.Should().BeEquivalentTo(expected);

        }
    }
}