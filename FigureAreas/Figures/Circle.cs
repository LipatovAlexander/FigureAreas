namespace FigureAreas.Figures;

public class Circle : Figure
{
    public Circle(double radius)
    {
        if (!IsValid(radius))
        {
            throw new ArgumentException("Radius must be positive.", nameof(radius));
        }
        
        Radius = radius;
    }

    private Circle()
    {
    }
    
    public double Radius { get; }
    
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
    
    private static bool IsValid(double radius)
    {
        return radius > 0;
    }
}