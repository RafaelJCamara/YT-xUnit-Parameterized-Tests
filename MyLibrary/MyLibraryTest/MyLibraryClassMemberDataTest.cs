using MyLibrary;
using MyLibraryTest.MyLibraryTestData;

namespace MyLibraryTest;

public class MyLibraryClassMemberDataTest
{
    [Theory]
    [MemberData(nameof(TestData.TotalSumMemberData), MemberType = typeof(TestData))]
    public void MemberDataTest_TotalSum(int el1, int el2, int el3, int totalSumExpected)
    {
        //Arrange
        var sut = new MyLibraryClass(el1,el2,el3);

        //Act
        var totalSum = sut.TotalSum();

        //Assert
        Assert.Equal(totalSumExpected, totalSum);
    }
}