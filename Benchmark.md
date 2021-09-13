``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1165 (21H1/May2021Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.303
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
  DefaultJob : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT


```
|    Type | Method |        Mean |     Error |    StdDev |  Gen 0 | Allocated |
|-------- |------- |------------:|----------:|----------:|-------:|----------:|
| Chechin |    Run |  3,306.7 ns |  51.65 ns |  45.79 ns | 0.8545 |   3,576 B |
|  Frolov |    Run |    596.7 ns |   4.35 ns |   3.63 ns | 0.4358 |   1,824 B |
|   Panov |    Run | 23,650.9 ns | 441.43 ns | 412.91 ns | 7.5073 |  31,480 B |
|   Yurin |    Run |    522.8 ns |   4.51 ns |   3.76 ns | 0.1049 |     440 B |
