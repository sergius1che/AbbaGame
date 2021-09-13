``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19043.1165 (21H1/May2021Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.303
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
  DefaultJob : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT


```
|    Type | Method |        Mean |     Error |    StdDev |      Median |  Gen 0 | Allocated |
|-------- |------- |------------:|----------:|----------:|------------:|-------:|----------:|
| Chechin |    Run |  3,608.7 ns |  64.73 ns |  57.38 ns |  3,606.9 ns | 0.8545 |   3,576 B |
|  Frolov |    Run |    636.6 ns |  12.52 ns |  25.01 ns |    631.6 ns | 0.4358 |   1,824 B |
| Novikov |    Run |    450.5 ns |   8.97 ns |  11.97 ns |    446.8 ns | 0.4358 |   1,824 B |
|   Panov |    Run | 25,687.5 ns | 418.53 ns | 391.49 ns | 25,698.1 ns | 7.5073 |  31,480 B |
|  Ryabiy |    Run |    235.6 ns |  12.47 ns |  35.97 ns |    219.4 ns | 0.0229 |      96 B |
|   Yurin |    Run |    690.4 ns |  13.50 ns |  25.02 ns |    685.3 ns | 0.1049 |     440 B |
