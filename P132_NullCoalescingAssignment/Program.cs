using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int>? list = null;
        (list ??= new List<int>()).Add(1);
        list.Add(2);
        Console.WriteLine(string.Join(",", list));
    }
}
