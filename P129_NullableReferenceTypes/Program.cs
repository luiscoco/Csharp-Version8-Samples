#nullable enable
using System;

class Person
{
    public string Name { get; }
    public string? Nickname { get; }
    public Person(string name, string? nickname = null)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Nickname = nickname;
    }
}

class Program
{
    static void Main()
    {
        var p = new Person("Ana");
        string? maybe = p.Nickname;
        Console.WriteLine(maybe ?? "no nickname");
    }
}
