using System;

class Square
{
    public double X { get; set; }
    public double Y { get; set; }
    public double SideLength { get; set; }
    
    public Square() { X = 0; Y = 0; SideLength = 1; }
    public Square(double x, double y, double sideLength) { X = x; Y = y; SideLength = sideLength; }
    public Square(Square other) { X = other.X; Y = other.Y; SideLength = other.SideLength; }

    public double Area() => SideLength * SideLength;
    public double Perimeter() => 4 * SideLength;
    public static Square operator +(Square s, double value) => new Square(s.X, s.Y, s.SideLength + value);
    public static Square operator /(Square s, double value) => value != 0 ? new Square(s.X, s.Y, s.SideLength / value) : throw new DivideByZeroException("Cannot divide by zero");
    public static Square operator +(Square s1, Square s2) => new Square(s1.X, s1.Y, s1.SideLength + s2.SideLength);
    public override string ToString() => $"Square: X={X}, Y={Y}, SideLength={SideLength}, Area={Area()}, Perimeter={Perimeter()}";
}

class Program
{
    static void Main()
    {
        Square K1 = new Square(1, 1, 4);
        Square K2 = new Square(2, 2, 5);
        Square K3 = new Square(3, 3, 6);
        Console.WriteLine(K1); Console.WriteLine(K2); Console.WriteLine(K3);
        K3 = K3 + 1;
        Console.WriteLine(K3);
        Square result = K2 / (K3.SideLength != 0 ? K3.SideLength : 1);
        Console.WriteLine(result);
        K1 = K1 + result;
        Console.WriteLine(K1);
    }
}