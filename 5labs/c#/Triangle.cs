public class Triangle : Figure
{
    private readonly (double x, double y) A, B, C;

    public Triangle(double ax, double ay, double bx, double by, double cx, double cy)
    {
        A = (ax, ay);
        B = (bx, by);
        C = (cx, cy);
    }

    private double Distance((double x, double y) p1, (double x, double y) p2)
    {
        return Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
    }

    public override double GetPerimeter()
    {
        return Distance(A, B) + Distance(B, C) + Distance(C, A);
    }

    public override double GetArea()
    {
        double a = Distance(A, B);
        double b = Distance(B, C);
        double c = Distance(C, A);
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    public override void Print()
    {
        Console.WriteLine("Triangle:");
        base.Print();
    }
}
