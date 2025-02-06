using Xunit;
using TriangleLib;

public class TriangleTests
{
    [Theory]
    [InlineData(3, 4, 5, true)]  // Valid triangle
    [InlineData(1, 1, 3, false)] // Invalid triangle
    [InlineData(5, 5, 5, true)]  // Equilateral triangle
    [InlineData(0, 0, 0, false)] // Zero-length sides
    public void TestIsTriangle(int a, int b, int c, bool expected)
    {
        Assert.Equal(expected, TriangleChecker.IsTriangle(a, b, c));
    }
}
