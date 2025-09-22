using System;

public struct Point
{
    public int X { get; }
    public int Y { get; }
    public Point(int x, int y) { X = x; Y = y; }

    public readonly double Length => Math.Sqrt(X * X + Y * Y);
    public readonly override string ToString() => $"({X},{Y})";
}

class Program
{
    static void Main()
    {
        var p = new Point(3, 4);
        Console.WriteLine(p);
        Console.WriteLine(p.Length);
    }
}
