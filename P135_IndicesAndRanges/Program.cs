using System;

class Program
{
    static void Main()
    {
        int[] a = { 10, 20, 30, 40, 50 };
        Index last = ^1;
        Range mid = 1..^1;
        Console.WriteLine(a[last]);
        var slice = a[mid];
        Console.WriteLine(string.Join(",", slice));
    }
}
