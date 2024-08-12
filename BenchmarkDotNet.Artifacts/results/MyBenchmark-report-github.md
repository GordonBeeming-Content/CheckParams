``` ini

BenchmarkDotNet=v0.13.1, OS=macOS 15.1 (24B5009l) [Darwin 24.1.0]
Apple M3 Max, 1 CPU, 14 logical and 14 physical cores
.NET SDK=9.0.100-preview.6.24328.19
  [Host]     : .NET 8.0.7 (8.0.724.31311), Arm64 RyuJIT
  DefaultJob : .NET 8.0.7 (8.0.724.31311), Arm64 RyuJIT


```
|                                 Method |      Mean |    Error |   StdDev |  Gen 0 | Allocated |
|--------------------------------------- |----------:|---------:|---------:|-------:|----------:|
|                    SixRouteVarExtended | 325.65 ns | 4.266 ns | 3.990 ns | 0.0792 |     664 B |
|                  SixRouteVarParamsOnly | 324.88 ns | 1.258 ns | 1.177 ns | 0.0849 |     712 B |
| SixRouteVarExtendedConvertToDictionary | 426.02 ns | 1.443 ns | 1.350 ns | 0.1240 |   1,040 B |
|                   FiveRouteVarExtended | 255.17 ns | 1.266 ns | 1.184 ns | 0.0687 |     576 B |
|                 FiveRouteVarParamsOnly | 279.80 ns | 3.051 ns | 2.854 ns | 0.0744 |     624 B |
|                   FourRouteVarExtended | 196.84 ns | 2.099 ns | 1.861 ns | 0.0572 |     480 B |
|                 FourRouteVarParamsOnly | 211.78 ns | 0.836 ns | 0.782 ns | 0.0629 |     528 B |
|                  ThreeRouteVarExtended | 140.76 ns | 0.602 ns | 0.534 ns | 0.0429 |     360 B |
|                ThreeRouteVarParamsOnly | 143.59 ns | 1.107 ns | 0.924 ns | 0.0515 |     432 B |
|                    TwoRouteVarExtended |  87.75 ns | 0.955 ns | 0.894 ns | 0.0334 |     280 B |
|                  TwoRouteVarParamsOnly |  91.67 ns | 0.434 ns | 0.406 ns | 0.0401 |     336 B |
|                    OneRouteVarExtended |  42.76 ns | 0.378 ns | 0.335 ns | 0.0249 |     208 B |
|                  OneRouteVarParamsOnly |  44.47 ns | 0.319 ns | 0.266 ns | 0.0296 |     248 B |
| OneRouteVarExtendedConvertToDictionary | 122.69 ns | 0.653 ns | 0.611 ns | 0.0842 |     704 B |
