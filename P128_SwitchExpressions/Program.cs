using System;

enum ShapeKind { Circle, Square, Triangle }

class Program
{
    static double Area(ShapeKind k, double a, double b = 0) =>
        k switch
        {
            ShapeKind.Circle => Math.PI * a * a,
            ShapeKind.Square => a * a,
            ShapeKind.Triangle => 0.5 * a * b,
            _ => throw new ArgumentOutOfRangeException(nameof(k))
        };

    static void Main()
    {
        Console.WriteLine(Area(ShapeKind.Circle, 2));
        Console.WriteLine(Area(ShapeKind.Square, 3));
        Console.WriteLine(Area(ShapeKind.Triangle, 3, 4));
    }
}
