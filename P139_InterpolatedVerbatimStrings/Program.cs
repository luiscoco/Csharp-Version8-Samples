using System;

class Program
{
    static void Main()
    {
        string name = "Ana";
        Console.WriteLine(@$"Path: C:\Users\{name}\docs");
        Console.WriteLine($@"Hello, {name}!");
    }
}
