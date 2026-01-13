# C# 8 Features – Sample Projects

This repository contains hands-on examples of the new features introduced in **C# version 8** (released with .NET Core 3.0 / .NET 5).  
Each project P126 - P140 illustrates one feature with runnable code.

---

## New Features in C# 8

### P126_ReadonlyMembers
- **What’s new**: Mark struct instance members as `readonly` to guarantee they don’t mutate state (reduces defensive copies).  
- **Example**:
  ```csharp
  struct Meter
  {
      public double Value { get; }
      public Meter(double v) => Value = v;
      public readonly override string ToString() => $"{Value} m";
  }
  ```

### P127_DefaultInterfaceMethods
- **What’s new**: Interfaces can provide method implementations without breaking existing implementers.  
- **Example**:
  ```csharp
  interface ILogger
  {
      void Write(string msg);
      void Info(string msg) => Write($"INFO: {msg}");
  }
  ```

### P128_SwitchExpressions
- **What’s new**: Concise, expression-bodied `switch` with pattern matching.  
- **Example**:
  ```csharp
  string Classify(int n) => n switch
  {
      < 0         => "neg",
      0           => "zero",
      > 0 and <10 => "small",
      _           => "large"
  };
  ```

### P129_PropertyTuplePositionalPatterns
- **What’s new**: Match on properties, tuples, and `Deconstruct`ed shapes.  
- **Example**:
  ```csharp
  var ok = person is { Age: >= 18 } 
        && (x, y) is (>= 0, >= 0);
  ```

### P130_UsingDeclarations
- **What’s new**: `using var stream = ...;` disposes at end of scope—no braces needed.  
- **Example**:
  ```csharp
  using var reader = File.OpenText("data.txt");
  Console.WriteLine(await reader.ReadToEndAsync());
  ```

### P131_StaticLocalFunctions
- **What’s new**: Local functions can be `static`, forbidding captures and enabling better perf.  
- **Example**:
  ```csharp
  int Sum(int[] xs)
  {
      static int Add(int a, int b) => a + b;
      return xs.Aggregate(0, Add);
  }
  ```

### P132_DisposableRefStructs
- **What’s new**: `ref struct`/`readonly ref struct` types can implement `IDisposable` and be used in `using`.  
- **Example**:
  ```csharp
  ref struct Buffer : IDisposable
  {
      private Span<byte> _span;
      public Buffer(Span<byte> s) => _span = s;
      public void Dispose() { /* return stack memory, etc. */ }
  }
  ```

### P133_NullableReferenceTypes
- **What’s new**: Annotate references with `?` and get compiler flow analysis to prevent `NullReferenceException`.  
- **Example**:
  ```csharp
  string? maybe = Get();
  Console.WriteLine(maybe?.Length);
  ```

### P134_AsyncStreams
- **What’s new**: Produce/consume asynchronous sequences with `IAsyncEnumerable<T>` and `await foreach`.  
- **Example**:
  ```csharp
  async IAsyncEnumerable<int> Counter()
  {
      for (int i = 0; i < 3; i++) { await Task.Delay(50); yield return i; }
  }

  await foreach (var n in Counter()) Console.WriteLine(n);
  ```

### P135_IndicesAndRanges
- **What’s new**: ^ from-end index and `..` slicing for arrays/spans/strings.  
- **Example**:
  ```csharp
  var last = numbers[^1];
  var middle = numbers[2..^2];
  ```

### P136_NullCoalescingAssignment
- **What’s new**: `x ??= value;` assigns only when `x` is null.  
- **Example**:
  ```csharp
  Dictionary<string,string>? map = null;
  (map ??= new()).Add("k", "v");
  ```

### P137_UnmanagedConstructedTypes
- **What’s new**: Generic type constrained with `where T : unmanaged` can itself be unmanaged when fields are unmanaged.  
- **Example**:
  ```csharp
  struct Pair<T> where T : unmanaged { public T X, Y; }
  ```

### P138_StackallocNestedExpressions
- **What’s new**: Use `stackalloc` inside other expressions (e.g., creating spans inline).  
- **Example**:
  ```csharp
  Span<int> span = stackalloc[] { 1, 2, 3 };
  var s = new ReadOnlySpan<int>(stackalloc[] { 4, 5, 6 });
  ```

### P139_InterpolatedVerbatimStrings
- **What’s new**: You can use either `$@"..."` or `@$"..."`.  
- **Example**:
  ```csharp
  var path = $@"C:\logs\{DateTime.Today:yyyyMMdd}.txt";
  ```

### P140_Patterns_Recap
- **What’s new**: Project combines property, tuple, and positional patterns into a single demo.  

---

## Repository Structure

- `P126_ReadonlyMembers` → readonly struct members  
- `P127_DefaultInterfaceMethods` → default interface implementations  
- `P128_SwitchExpressions` → switch expressions  
- `P129_PropertyTuplePositionalPatterns` → property/tuple/positional patterns  
- `P130_UsingDeclarations` → using declarations  
- `P131_StaticLocalFunctions` → static local functions  
- `P132_DisposableRefStructs` → disposable `ref struct`  
- `P133_NullableReferenceTypes` → nullable reference types  
- `P134_AsyncStreams` → `IAsyncEnumerable<T>` and `await foreach`  
- `P135_IndicesAndRanges` → `^` and `..`  
- `P136_NullCoalescingAssignment` → `??=`  
- `P137_UnmanagedConstructedTypes` → unmanaged constructed generics  
- `P138_StackallocNestedExpressions` → `stackalloc` in nested expressions  
- `P139_InterpolatedVerbatimStrings` → interpolated verbatim strings  
- `P140_Patterns_Recap` → pattern matching recap  

---

## Requirements

- .NET Core 3.0+ / .NET 5 SDK  
- C# 8 language version  

To build & run a sample:
```bash
dotnet restore
dotnet build
dotnet run --project P130_AsyncStreams
```

---

## References

- [What’s new in C# 8.0 – Microsoft Learn](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-8)  
- [.NET Blog: Building C# 8.0](https://devblogs.microsoft.com/dotnet/building-c-8-0/)  
