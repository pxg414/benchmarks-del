This project uses [BenchmarkDotNet](http://benchmarkdotnet.org/) to compare performance of different versions of the library.

``` ini

BenchmarkDotNet=v0.11.3, OS=Windows 10.0.17134.523 (1803/April2018Update/Redstone4)
Intel Core i7-6700K CPU 4.00GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
Frequency=3914058 Hz, Resolution=255.4893 ns, Timer=TSC
  [Host]     : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0
  Job-NIEANE : .NET Framework 4.7.2 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.3260.0

InvocationCount=100000  LaunchCount=1  RunStrategy=Throughput  

```
|       Method |  Version |        Mean |      Error |     StdDev |
|------------- |--------- |------------:|-----------:|-----------:|
|    **Singleton** | **4.0.1** |   **455.53 ns** |  **4.3610 ns** |  **4.0793 ns** |
| Unregistered | 4.0.1 |   893.14 ns |  3.9070 ns |  3.6546 ns |
|    Transient | 4.0.1 |   906.03 ns |  4.0031 ns |  3.5487 ns |
|      Mapping | 4.0.1 |   776.70 ns |  2.3000 ns |  2.1514 ns |
|        Array | 4.0.1 | 8,725.32 ns | 36.1246 ns | 33.7909 ns |
|   Enumerable | 4.0.1 |          NA |         NA |         NA |
|    **Singleton** | **5.8.13** |   **127.87 ns** |  **0.9838 ns** |  **0.9203 ns** |
| Unregistered | 5.8.13 |   128.18 ns |  1.2329 ns |  1.1532 ns |
|    Transient | 5.8.13 |   143.36 ns |  1.7001 ns |  1.5071 ns |
|      Mapping | 5.8.13 |   141.33 ns |  1.4194 ns |  1.3278 ns |
|        Array | 5.8.13 |   642.21 ns |  4.4079 ns |  3.9075 ns |
|   Enumerable | 5.8.13 |   739.89 ns |  3.5254 ns |  3.2977 ns |
|    **Singleton** | **5.9.0** |    **76.19 ns** |  **0.8752 ns** |  **0.8187 ns** |
| Unregistered | 5.9.0 |    88.37 ns |  0.8162 ns |  0.7635 ns |
|    Transient | 5.9.0 |    96.90 ns |  1.3002 ns |  1.1526 ns |
|      Mapping | 5.9.0 |   122.58 ns |  2.4451 ns |  2.4014 ns |
|        Array | 5.9.0 |   605.97 ns |  5.6593 ns |  5.2937 ns |
|   Enumerable | 5.9.0 |   669.90 ns |  5.6207 ns |  4.6935 ns |
