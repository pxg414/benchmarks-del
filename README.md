# Unity Container Benchmarks

``` ini

BenchmarkDotNet=v0.10.10, OS=Windows 10 Redstone 2 [1703, Creators Update] (10.0.15063.726)
Processor=Intel Core i7-6700K CPU 4.00GHz (Skylake), ProcessorCount=8
Frequency=3914064 Hz, Resolution=255.4889 ns, Timer=TSC
  [Host]     : .NET Framework 4.6 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2115.0
  DefaultJob : .NET Framework 4.6 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2115.0


```
|                                   Method | Version |     Mean |     Error |    StdDev |
|----------------------------------------- |-------- |---------:|----------:|----------:|
|                   'new UnityContainer()' |      V4 | 6.385 us | 0.0117 us | 0.0109 us |
|                   'new UnityContainer()' |      V5 | 3.365 us | 0.0020 us | 0.0017 us |
|                   'new UnityContainer()' |      V6 | 3.442 us | 0.0042 us | 0.0037 us |
| 'using(var uc = new UnityContainer()){}' |      V4 | 6.803 us | 0.0173 us | 0.0154 us |
| 'using(var uc = new UnityContainer()){}' |      V5 | 3.564 us | 0.0044 us | 0.0039 us |
| 'using(var uc = new UnityContainer()){}' |      V6 | 3.649 us | 0.0034 us | 0.0026 us |

