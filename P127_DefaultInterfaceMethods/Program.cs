using System;

interface IGreeter
{
    void Hello(string name) => Console.WriteLine($"Hello, {name}!");
    string Upper(string s) => s.ToUpperInvariant();
}

class SimpleGreeter : IGreeter {}
class LoudGreeter : IGreeter
{
    public void Hello(string name) => Console.WriteLine($"HELLO, {name.ToUpperInvariant()}!");
}

class Program
{
    static void Main()
    {
        IGreeter g1 = new SimpleGreeter();
        g1.Hello("Ana");
        Console.WriteLine(g1.Upper("quiet"));

        IGreeter g2 = new LoudGreeter();
        g2.Hello("Bob");
    }
}
