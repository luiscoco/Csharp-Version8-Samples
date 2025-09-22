using System;

class Program
{
    static void Main()
    {
        // Use the implicit conversion from stackalloc to Span<int>
        Span<int> s = stackalloc int[] { 1, 2, 3 };

        int total = 0;
        for (int i = 0; i < s.Length; i++)
            total += s[i];

        Console.WriteLine(total);
    }
}
