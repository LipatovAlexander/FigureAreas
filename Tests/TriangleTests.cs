namespace Tests;

public class TriangleTests
{
    [Fact]
    public void Should_Throw_When_Sides_Are_Invalid()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, 2));
    }
    
    [Theory]
    [InlineData(1, 1, 1, 0.433)]
    [InlineData(2, 2, 3, 1.9843)]
    [InlineData(10, 13, 16, 64.919)]
    public void Should_Get_Right_Area_When_Sides_Are_Valid(double sideA, double sideB, double sideC, double expectedArea)
    {
        var triangle = new Triangle(sideA, sideB, sideC);
        TestHelper.AssertArea(triangle, expectedArea);
    }
    
    [Theory]
    [InlineData(3, 4, 5, 6)]
    [InlineData(5, 12, 13, 30)]
    [InlineData(8, 15, 17, 60)]
    public void Should_Get_Right_Area_When_Triangle_Is_Right(double sideA, double sideB, double sideC, double expectedArea)
    {
        var triangle = new Triangle(sideA, sideB, sideC);
        TestHelper.AssertArea(triangle, expectedArea);
    }
}