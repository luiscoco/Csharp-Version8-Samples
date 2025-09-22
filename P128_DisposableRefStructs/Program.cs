using System;

ref struct TempBuffer
{
    public Span<int> Data;
    public TempBuffer(Span<int> data) { Data = data; }
    public void Dispose() { Console.WriteLine("TempBuffer disposed"); }
}

class Program
{
    static void Main()
    {
        Span<int> s = stackalloc int[3];
        using var tmp = new TempBuffer(s);
        tmp.Data[0] = 1; tmp.Data[1] = 2; tmp.Data[2] = 3;
        Console.WriteLine(tmp.Data[0] + tmp.Data[1] + tmp.Data[2]);
    }
}
