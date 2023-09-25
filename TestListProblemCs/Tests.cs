namespace TestListProblem {

using System;
using Xunit;
using FsUnitTyped;

public class Tests
{
    [Theory]
    [InlineData("1", 1)]
    [InlineData("2", 2)]
    public void ConvertSomeStringsToInts (string str, int expected)
    {
        var actual = Int32.Parse(str);
        FsUnitTyped.TopLevelOperators.shouldEqual<int>(expected, actual);
    }
}
}