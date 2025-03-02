```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.3323)
AMD Ryzen 7 7735U with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


```
| Method             | Mean     | Error     | StdDev    | Gen0   | Gen1   | Allocated |
|------------------- |---------:|----------:|----------:|-------:|-------:|----------:|
| SortArray          | 3.252 μs | 0.0199 μs | 0.0186 μs |      - |      - |         - |
| SortArrayUsingLinq | 9.940 μs | 0.1479 μs | 0.1235 μs | 1.9379 | 0.1068 |   16304 B |
