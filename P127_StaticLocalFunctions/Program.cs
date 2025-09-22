using System;

class Program
{
    static void Main()
    {
        int factor = 3;
        int Multiply(int x) => x * factor;
        static int MultiplyStatic(int x, int f) => x * f;

        Console.WriteLine(Multiply(4));
        Console.WriteLine(MultiplyStatic(4, 5));
    }
}
