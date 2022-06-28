using FigureAreas;

namespace Tests;

public class FigureTests
{
    [Theory]
    [MemberData(nameof(GetData))]
    public void Should_Get_Right_Area(Figure figure, double expectedArea)
    {
        TestHelper.AssertArea(figure, expectedArea);
    }
    
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[] { new Triangle(10, 10, 10), 43.301 };
        yield return new object[] { new Circle(10), 314.16 };
    }
}