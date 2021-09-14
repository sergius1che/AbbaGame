``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1165 (21H1/May2021Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.303
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
  DefaultJob : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT


```
|        Type | Method |        Mean |     Error |    StdDev |  Gen 0 | Allocated |
|------------ |------- |------------:|----------:|----------:|-------:|----------:|
| Bezruchenko |    Run |  1,777.2 ns |  26.04 ns |  24.35 ns | 0.4902 |   2,056 B |
|     Borisov |    Run |  1,829.9 ns |  15.75 ns |  13.15 ns | 0.0458 |     200 B |
|     Chechin |    Run |  3,748.0 ns |  26.85 ns |  20.96 ns | 0.8545 |   3,576 B |
|      Frolov |    Run |    630.0 ns |  11.51 ns |  23.26 ns | 0.4358 |   1,824 B |
|     Novikov |    Run |    409.8 ns |   6.83 ns |   5.70 ns | 0.4358 |   1,824 B |
|       Panov |    Run | 24,482.6 ns | 242.55 ns | 202.54 ns | 7.5073 |  31,480 B |
|      Ryabiy |    Run |    190.3 ns |   2.88 ns |   2.40 ns | 0.0229 |      96 B |
|       Yurin |    Run |    590.2 ns |   7.29 ns |   6.09 ns | 0.1049 |     440 B |
