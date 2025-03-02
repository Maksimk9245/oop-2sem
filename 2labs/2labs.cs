using System;

class Vector
{
    private double x, y;

    // Конструкторы
    public Vector() // Конструктор по умолчанию
    {
        x = 0;
        y = 0;
    }

    public Vector(double x, double y) // Конструктор с параметрами
    {
        this.x = x;
        this.y = y;
    }

    public Vector(Vector other) // Конструктор копирования
    {
        this.x = other.x;
        this.y = other.y;
    }

    // Деструктор
    ~Vector()
    {
        Console.WriteLine("Объект Vector уничтожен");
    }

    // Методы доступа
    public double GetX() => x;
    public double GetY() => y;

    // Метод вычисления полярных координат
    public (double r, double theta) ToPolar()
    {
        double r = Math.Sqrt(x * x + y * y);
        double theta = Math.Atan2(y, x);
        return (r, theta);
    }
}

class Program
{
    static void Main()
    {
        Vector v1 = new Vector(3, 4);
        Console.WriteLine($"Создан вектор с координатами ({v1.GetX()}, {v1.GetY()})");
    }
}
