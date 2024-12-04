using MyLibrary;

namespace MyLibraryTest;

public class MyLibraryClassInlineDataTest
{
    [Theory]
    [InlineData(1, 2, 3, 6)]
    [InlineData(1, 2, 4, 7)]
    [InlineData(1, 2, 5, 8)]
    public void InlineDataTest_TotalSum(int el1, int el2, int el3, int totalSumExpected)
    {
        //Arrange
        var sut = new MyLibraryClass(el1,el2,el3);

        //Act
        var totalSum = sut.TotalSum();

        //Assert
        Assert.Equal(totalSumExpected, totalSum);
    }
}