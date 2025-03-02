using System;

class Vector
{
    private double x;
    private double y;

    public Vector(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double Length()
    {
        return Math.Sqrt(x * x + y * y);
    }

    public double Angle()
    {
        return Math.Atan2(y, x) * (180 / Math.PI); // градус в углах
    }

    public void PrintVector()
    {
        Console.WriteLine($"Координаты конца вектора: ({x}, {y})");
    }

    public void PrintPolarCoordinates()
    {
        Console.WriteLine($"Длина вектора: {Length():F2}");
        Console.WriteLine($"Угол (градусы): {Angle():F2}");
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите координату x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координату y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        Vector vector = new Vector(x, y);
        vector.PrintVector();
        vector.PrintPolarCoordinates();
    }
}
