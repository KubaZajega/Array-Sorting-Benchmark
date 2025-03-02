```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3323)
AMD Ryzen 7 7735U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


```
| Method                     | Mean      | Error     | StdDev    | Gen0     | Gen1   | Allocated  |
|--------------------------- |----------:|----------:|----------:|---------:|-------:|-----------:|
| StringConcatenation        | 92.962 μs | 1.8261 μs | 2.6766 μs | 339.5996 | 4.6387 | 2773.88 KB |
| StringBuilderConcatenation |  3.420 μs | 0.0219 μs | 0.0194 μs |   1.7586 | 0.0572 |   14.37 KB |
