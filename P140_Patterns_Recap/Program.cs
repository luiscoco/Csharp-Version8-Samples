using System;

class LegacyPoint
{
    public int X { get; }
    public int Y { get; }
    public LegacyPoint(int x, int y){ X=x; Y=y; }
    public void Deconstruct(out int x, out int y){ x=X; y=Y; }
}

class Program
{
    static string Classify(object o) => o switch
    {
        LegacyPoint { X: 0, Y: 0 } => "origin",
        LegacyPoint { Y: var y } when y > 0 => "upper-half",
        (int a, int b) when a == b => "diag",
        LegacyPoint(var x, var y) when x > 0 && y > 0 => "Q1",
        _ => "other"
    };

    static void Main()
    {
        Console.WriteLine(Classify(new LegacyPoint(0,0)));
        Console.WriteLine(Classify(new LegacyPoint(2,3)));
        Console.WriteLine(Classify((4,4)));
    }
}
