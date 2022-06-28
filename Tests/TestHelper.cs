using FigureAreas;

namespace Tests;

public class TestHelper
{
    public static void AssertArea(Figure figure, double expectedArea)
    {
        var actual = figure.GetArea();
        var areEqual = Math.Abs(actual - expectedArea) < 0.001;
        
        Assert.True(areEqual, $"Expected area: {expectedArea}, actual area: {actual}");
    }
}