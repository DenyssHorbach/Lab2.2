using System;

public class Vector : IComparable<Vector>
{
    public string LineColor { get; set; }
    public double X { get; set; }
    public double Y { get; set; }

    public Vector()
    {
        LineColor = "White";
        X = 0;
        Y = 0;
    }

    public Vector(string lineColor, double x, double y)
    {
        LineColor = lineColor;
        X = x;
        Y = y;
    }

    public double GetLength()
    {
        return Math.Sqrt(X * X + Y * Y);
    }

    public void Increase(double deltaX, double deltaY)
    {
        X += deltaX;
        Y += deltaY;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Vector [Color: {LineColor}, End coordinates: ({X}; {Y}), Length: {GetLength():F2}]");
    }

    public int CompareTo(Vector other)
    {
        if (other == null) return 1;
        return this.GetLength().CompareTo(other.GetLength());
    }
}