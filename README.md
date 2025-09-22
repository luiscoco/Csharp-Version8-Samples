# C# Version 8.0 – Feature Samples

This solution contains **mini-projects (P122–P136)**, each demonstrating a new language feature introduced in **C# 8.0** (Visual Studio 2019, .NET Core 3.0 / .NET 5+).

---

## Feature Index

### Struct & Interface Improvements
- **P122_ReadonlyMembers**  
  Demonstrates `readonly` members in structs. Prevents accidental copies and enforces immutability.

- **P123_DefaultInterfaceMethods**  
  Interfaces can now contain methods with a default implementation.

---

### Pattern Matching Enhancements
- **P124_SwitchExpressions**  
  Concise `switch` expressions with expression-bodied syntax.

- **P125_PropertyTuplePositionalPatterns**  
  Shows property patterns (`{ Age: >= 18 }`), tuple patterns (`(x, y)`), and positional patterns (via `Deconstruct`).

- **P136_Patterns_Recap**  
  Combined demo of property, tuple, and positional patterns.

---

### Using & Local Functions
- **P126_UsingDeclarations**  
  `using var resource = ...;` disposes automatically at the end of scope.

- **P127_StaticLocalFunctions**  
  Local functions can be declared `static` to prevent capturing variables.

- **P128_DisposableRefStructs**  
  `ref struct` types can now implement `Dispose` and be used with `using`.

---

### Nullable, Async, and Data Features
- **P129_NullableReferenceTypes**  
  Nullable annotations (`string?`) with compiler flow analysis for null safety.

- **P130_AsyncStreams**  
  Asynchronous streams with `IAsyncEnumerable<T>` and `await foreach`.

---

### Operators, Indices, and Ranges
- **P131_IndicesAndRanges**  
  Demonstrates the `^` (from-end) operator and `..` range slicing.

- **P132_NullCoalescingAssignment**  
  The `??=` operator for assigning a default value only if null.

---

### Advanced Unsafe / Memory Features
- **P133_UnmanagedConstructedTypes**  
  Generic types constrained with `where T : unmanaged`.  
  (Requires `unsafe`.)

- **P134_StackallocNestedExpressions**  
  `stackalloc` arrays used inside nested expressions (e.g., `new Span<int>(stackalloc ... )`).

---

### Strings
- **P135_InterpolatedVerbatimStrings**  
  Both `$@"..."` and `@$"..."` forms supported for interpolated verbatim strings.

---

## How to Run
1. Open solution `CSharpV80_Features.sln` in Visual Studio 2022+ (or VS Code).  
2. Select a project (P122–P136) as startup project.  
3. Run with `Ctrl+F5`.  

Or run from command line:
```bash
dotnet run --project P130_AsyncStreams
```

---

👉 Each project is self-contained and shows a minimal but complete program demonstrating the feature.
