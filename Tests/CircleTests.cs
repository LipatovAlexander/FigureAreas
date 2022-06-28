namespace Tests;

public class CircleTests
{
    [Fact]
    public void Should_Throw_When_Radius_Less_Than_Zero()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
    
    [Theory]
    [InlineData(1, Math.PI)]
    [InlineData(2, 12.566)]
    [InlineData(3, 28.274)]
    [InlineData(4, 50.265)]
    [InlineData(5, 78.54)]
    public void Should_Get_Right_Area_When_Radius_Is_Valid(double radius, double expectedArea)
    {
        var circle = new Circle(radius);
        TestHelper.AssertArea(circle, expectedArea);
    }
}