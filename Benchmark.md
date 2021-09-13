``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1165 (21H1/May2021Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.303
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
  DefaultJob : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT


```
|        Type | Method |        Mean |     Error |    StdDev |      Median |  Gen 0 | Allocated |
|------------ |------- |------------:|----------:|----------:|------------:|-------:|----------:|
| Bezruchenko |    Run |  2,250.8 ns |  50.99 ns | 144.66 ns |  2,237.0 ns | 0.4883 |   2,056 B |
|     Chechin |    Run |  4,486.6 ns |  89.69 ns | 206.08 ns |  4,441.1 ns | 0.8545 |   3,576 B |
|      Frolov |    Run |    747.6 ns |  23.87 ns |  66.94 ns |    726.5 ns | 0.4358 |   1,824 B |
|     Novikov |    Run |    499.0 ns |   9.89 ns |  10.99 ns |    497.7 ns | 0.4358 |   1,824 B |
|       Panov |    Run | 28,283.3 ns | 551.84 ns | 541.98 ns | 28,270.5 ns | 7.5073 |  31,480 B |
|      Ryabiy |    Run |    218.9 ns |   4.34 ns |   4.45 ns |    217.7 ns | 0.0229 |      96 B |
|       Yurin |    Run |    713.3 ns |  11.14 ns |   9.30 ns |    715.3 ns | 0.1049 |     440 B |
