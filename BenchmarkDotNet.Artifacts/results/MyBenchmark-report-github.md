``` ini

BenchmarkDotNet=v0.13.1, OS=macOS 15.1 (24B5009l) [Darwin 24.1.0]
Apple M3 Max, 1 CPU, 14 logical and 14 physical cores
.NET SDK=9.0.100-preview.6.24328.19
  [Host]     : .NET 8.0.7 (8.0.724.31311), Arm64 RyuJIT
  DefaultJob : .NET 8.0.7 (8.0.724.31311), Arm64 RyuJIT


```
|                  Method |      Mean |    Error |   StdDev |  Gen 0 | Allocated |
|------------------------ |----------:|---------:|---------:|-------:|----------:|
|     SixRouteVarExtended | 315.77 ns | 1.248 ns | 1.043 ns | 0.0792 |     664 B |
|   SixRouteVarParamsOnly | 328.50 ns | 4.948 ns | 4.628 ns | 0.0849 |     712 B |
|    FiveRouteVarExtended | 255.78 ns | 2.981 ns | 2.642 ns | 0.0687 |     576 B |
|  FiveRouteVarParamsOnly | 270.57 ns | 4.126 ns | 3.859 ns | 0.0744 |     624 B |
|    FourRouteVarExtended | 189.87 ns | 0.943 ns | 0.836 ns | 0.0572 |     480 B |
|  FourRouteVarParamsOnly | 198.54 ns | 0.790 ns | 0.739 ns | 0.0629 |     528 B |
|   ThreeRouteVarExtended | 134.35 ns | 0.655 ns | 0.613 ns | 0.0429 |     360 B |
| ThreeRouteVarParamsOnly | 140.59 ns | 0.802 ns | 0.750 ns | 0.0515 |     432 B |
|     TwoRouteVarExtended |  82.18 ns | 0.243 ns | 0.227 ns | 0.0334 |     280 B |
|   TwoRouteVarParamsOnly |  93.27 ns | 1.204 ns | 1.126 ns | 0.0401 |     336 B |
|     OneRouteVarExtended |  41.76 ns | 0.198 ns | 0.166 ns | 0.0249 |     208 B |
|   OneRouteVarParamsOnly |  41.98 ns | 0.126 ns | 0.118 ns | 0.0296 |     248 B |
