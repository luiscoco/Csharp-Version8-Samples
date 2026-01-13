using System;

unsafe struct Buffer<T> where T : unmanaged
{
    public T* Ptr;
    public int Length;
    public Buffer(T* ptr, int len) { Ptr = ptr; Length = len; }
}

class Program
{
    unsafe static void Main()
    {
        int len = 3;
        int* p = stackalloc int[len];
        p[0]=1; p[1]=2; p[2]=3;
        Buffer<int> buf = new Buffer<int>(p, len);
        int sum = 0;
        for (int i=0;i<buf.Length;i++) sum += buf.Ptr[i];
        Console.WriteLine(sum);
    }
}
