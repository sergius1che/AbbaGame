``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1165 (21H1/May2021Update)
AMD Ryzen 5 1500X, 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.400
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
  DefaultJob : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT


```
|    Type | Method |        Mean |     Error |    StdDev |  Gen 0 | Allocated |
|-------- |------- |------------:|----------:|----------:|-------:|----------:|
| Chechin |    Run |  3,651.7 ns |  54.73 ns |  48.51 ns | 0.8545 |   3,576 B |
|   Panov |    Run | 33,973.6 ns | 414.01 ns | 345.72 ns | 7.5073 |  31,480 B |
|   Yurin |    Run |    683.0 ns |   2.58 ns |   2.41 ns | 0.1049 |     440 B |
