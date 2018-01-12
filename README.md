``` ini

BenchmarkDotNet=v0.10.10, OS=Windows 10 Redstone 2 [1703, Creators Update] (10.0.15063.726)
Processor=Intel Core i7-6700K CPU 4.00GHz (Skylake), ProcessorCount=8
Frequency=3914064 Hz, Resolution=255.4889 ns, Timer=TSC
  [Host]     : .NET Framework 4.6 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2115.0
  DefaultJob : .NET Framework 4.6 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2115.0


```
# Basic

|                              Method |  Version |        Mean |      Error |     StdDev |
|------------------------------------ |--------- |------------:|-----------:|-----------:|
|      Container.Resolve<Container>() | Unity.V4 |    458.2 ns |   2.415 ns |   2.016 ns |
|      Container.Resolve<Container>() | Unity.V5 |    737.9 ns |  10.072 ns |   9.421 ns |
|    `Container.Resolve<Container>()` | Unity.V6 |    479.4 ns |   8.566 ns |   7.593 ns |
|  ``Container.Resolve<Container>()`` |   VS_MEF |  2,814.9 ns |  14.542 ns |  13.602 ns |
|                   'new Container()' | Unity.V4 |  6,489.4 ns |  55.737 ns |  52.137 ns |
|                   'new Container()' | Unity.V5 |  3,370.8 ns |  12.191 ns |  10.180 ns |
|                   'new Container()' | Unity.V6 |  3,462.3 ns |  24.325 ns |  20.313 ns |
|                   'new Container()' |   VS_MEF | 57,311.7 ns | 349.694 ns | 327.104 ns |
| 'using(var uc = new Container()){}' | Unity.V4 |  6,828.1 ns |  97.852 ns |  91.531 ns |
| 'using(var uc = new Container()){}' | Unity.V5 |  3,641.0 ns |  54.798 ns |  51.258 ns |
| 'using(var uc = new Container()){}' | Unity.V6 |  3,712.5 ns |  24.850 ns |  20.751 ns |
| 'using(var uc = new Container()){}' |   VS_MEF | 58,291.3 ns | 582.364 ns | 544.744 ns |

# Registration

|                                    Method |  Version |       Mean |     Error |     StdDev |
|------------------------------------------ |--------- |-----------:|----------:|-----------:|
|         'Register Named Type (Singleton)' | Unity.V4 | 1,266.3 ns | 10.676 ns |  9.4644 ns |
|         'Register Named Type (Singleton)' | Unity.V5 |   797.0 ns |  8.250 ns |  7.7173 ns |
|         'Register Named Type (Singleton)' | Unity.V6 |   785.8 ns | 15.428 ns | 18.9474 ns |
|         'Register Named Type (Singleton)' |   VS_MEF |         NA |        NA |         NA |
| 'Register Named Type Mapping (Singleton)' | Unity.V4 | 2,231.8 ns |  5.173 ns |  4.8387 ns |
| 'Register Named Type Mapping (Singleton)' | Unity.V5 |   975.5 ns |  4.871 ns |  4.5559 ns |
| 'Register Named Type Mapping (Singleton)' | Unity.V6 |   928.4 ns |  3.146 ns |  2.9432 ns |
| 'Register Named Type Mapping (Singleton)' |   VS_MEF |         NA |        NA |         NA |
|             'Register Named Type Mapping' | Unity.V4 | 1,048.3 ns | 14.301 ns | 13.3769 ns |
|             'Register Named Type Mapping' | Unity.V5 |   525.5 ns |  1.244 ns |  0.8993 ns |
|             'Register Named Type Mapping' | Unity.V6 |   592.1 ns |  1.191 ns |  1.0558 ns |
|             'Register Named Type Mapping' |   VS_MEF |         NA |        NA |         NA |
|                     'Register Named Type' | Unity.V4 |   213.4 ns |  1.860 ns |  1.7395 ns |
|                     'Register Named Type' | Unity.V5 |   351.7 ns |  3.796 ns |  3.5511 ns |
|                     'Register Named Type' | Unity.V6 |   327.7 ns |  1.702 ns |  1.5083 ns |
|                     'Register Named Type' |   VS_MEF |         NA |        NA |         NA |
|               'Register Type (Singleton)' | Unity.V4 | 1,250.3 ns |  7.761 ns |  7.2592 ns |
|               'Register Type (Singleton)' | Unity.V5 |   772.4 ns | 14.011 ns | 13.1062 ns |
|               'Register Type (Singleton)' | Unity.V6 |   769.6 ns |  9.400 ns |  7.8498 ns |
|               'Register Type (Singleton)' |   VS_MEF |         NA |        NA |         NA |
|       'Register Type Mapping (Singleton)' | Unity.V4 | 2,172.8 ns | 12.255 ns | 11.4635 ns |
|       'Register Type Mapping (Singleton)' | Unity.V5 |   954.3 ns | 18.295 ns | 17.9685 ns |
|       'Register Type Mapping (Singleton)' | Unity.V6 |   899.3 ns | 14.865 ns | 13.9049 ns |
|       'Register Type Mapping (Singleton)' |   VS_MEF |         NA |        NA |         NA |
|                   'Register Type Mapping' | Unity.V4 | 1,022.7 ns |  4.795 ns |  4.4853 ns |
|                   'Register Type Mapping' | Unity.V5 |   491.9 ns |  2.977 ns |  2.6387 ns |
|                   'Register Type Mapping' | Unity.V6 |   483.1 ns |  1.269 ns |  1.1252 ns |
|                   'Register Type Mapping' |   VS_MEF |         NA |        NA |         NA |
|                           'Register Type' | Unity.V4 |   193.9 ns |  2.441 ns |  2.2837 ns |
|                           'Register Type' | Unity.V5 |   313.6 ns |  3.451 ns |  3.2280 ns |
|                           'Register Type' | Unity.V6 |   353.1 ns |  1.980 ns |  1.6531 ns |
|                           'Register Type' |   VS_MEF |         NA |        NA |         NA |
