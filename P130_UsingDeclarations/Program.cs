using System;
using System.IO;

class Program
{
    static void Main()
    {
        using var sw = new StringWriter();
        sw.WriteLine("Hello");
        sw.WriteLine("Using declarations clean up at scope end.");
        Console.Write(sw.ToString());
    }
}
