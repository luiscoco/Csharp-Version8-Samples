using System;

public class Person
{
    public string Name { get; set; } = "";
    public int Age { get; set; }
    public void Deconstruct(out string name, out int age) { name = Name; age = Age; }
}

class Program
{
    static string Describe(object? o) => o switch
    {
        Person { Age: var age } p when age >= 18 => $"Adult {p.Name}",
        Person { Age: var age2 } p when age2 < 18 => $"Minor {p.Name}",
        (int x, int y) when x == y => "on diagonal",
        (int _, int _) => "a point",
        Person(_, var age) when age >= 65 => "Senior person",
        _ => "unknown"
    };

    static void Main()
    {
        Console.WriteLine(Describe(new Person{ Name="Ana", Age=20 }));
        Console.WriteLine(Describe(new Person{ Name="Bob", Age=12 }));
        Console.WriteLine(Describe((3,3)));
        Console.WriteLine(Describe((2,5)));
        Console.WriteLine(Describe(new Person{ Name="Cara", Age=70 }));
    }
}
