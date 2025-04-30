public abstract class Figure
{
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public virtual void Print()
    {
        Console.WriteLine($"Area: {GetArea():F2}, Perimeter: {GetPerimeter():F2}");
    }
}
