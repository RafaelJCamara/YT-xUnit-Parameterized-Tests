using System.Collections;

namespace MyLibraryTest.MyLibraryTestData;

public static class TestData
{
    public static IEnumerable<object[]> TotalSumMemberData => new List<object[]>
    {
        new object[]{ 1, 2, 3, 6 },
        new object[]{ 1, 2, 4, 7 },
        new object[]{ 1, 2, 5, 8 }
    };
}

public class TotalSumClassData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[] { 1, 2, 3, 6 };
        yield return new object[] { 1, 2, 4, 7 };
        yield return new object[] { 1, 2, 5, 8 };
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}


public class TotalSumTheoryData : TheoryData<int, int, int, int>
{
    public TotalSumTheoryData()
    {
        Add(1,2,3,6);
        Add(1,2,4,7);
        Add(1,2,5,8);
    }
}