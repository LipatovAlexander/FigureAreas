namespace FigureAreas.Figures;

public class Triangle : Figure
{
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (!IsValid(sideA, sideB, sideC))
        {
            throw new ArgumentException("Invalid triangle sides.");
        }
        
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    private Triangle()
    {
    }
    
    public double SideC { get; }

    public double SideB { get; }
    
    public double SideA { get; }

    public override double GetArea()
    {
        var sortedSides = new[] {SideA, SideB, SideC}.OrderBy(x => x).ToArray();
        if (IsRightTriangle(sortedSides))
        {
            return sortedSides[0] * sortedSides[1] / 2;
        }
        
        return HeronFormula();
    }
    
    private double HeronFormula()
    {
        var semiPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
    }
    
    private static bool IsRightTriangle(IReadOnlyList<double> sortedSides)
    {
        return Math.Abs(sortedSides[0] * sortedSides[0] + sortedSides[1] * sortedSides[1] - sortedSides[2] * sortedSides[2]) < double.Epsilon;
    }
    
    private static bool IsValid(double sideA, double sideB, double sideC)
    {
        return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
    }
}