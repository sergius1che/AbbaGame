``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1165 (21H1/May2021Update)
AMD Ryzen 5 1500X, 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.400
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
  DefaultJob : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT


```
| Method |     Mean |     Error |    StdDev |  Gen 0 | Allocated |
|------- |---------:|----------:|----------:|-------:|----------:|
|    Run | 3.710 μs | 0.0258 μs | 0.0228 μs | 0.8545 |      3 KB |
