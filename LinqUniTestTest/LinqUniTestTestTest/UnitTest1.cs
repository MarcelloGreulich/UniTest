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
            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            List<string> expected = new List<string>();
            expected.Add($"Number 5 ist 3 vorhanden");
            expected.Add($"Number 9 ist 2 vorhanden");
            expected.Add($"Number 1 ist 1 vorhanden");
            expected.Add($"Number 2 ist 2 vorhanden");
            expected.Add($"Number 3 ist 2 vorhanden");
            expected.Add($"Number 7 ist 3 vorhanden");
            expected.Add($"Number 6 ist 3 vorhanden");
            expected.Add($"Number 8 ist 1 vorhanden");
            expected.Add($"Number 4 ist 1 vorhanden");

            //Act
            List<string> intArr = LinqUnit.Count(arr1);

            //Assert

            intArr.Should().BeEquivalentTo(expected);

        }
    }
}