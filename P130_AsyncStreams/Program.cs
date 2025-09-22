using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async IAsyncEnumerable<int> CountAsync()
    {
        for (int i = 1; i <= 3; i++)
        {
            await Task.Delay(100);
            yield return i;
        }
    }

    static async Task Main()
    {
        await foreach (var x in CountAsync())
            Console.WriteLine(x);
    }
}
