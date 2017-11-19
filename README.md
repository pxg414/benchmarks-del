``` ini

BenchmarkDotNet=v0.10.10, OS=Windows 10 Redstone 2 [1703, Creators Update] (10.0.15063.726)
Processor=Intel Core i7-6700K CPU 4.00GHz (Skylake), ProcessorCount=8
Frequency=3914064 Hz, Resolution=255.4889 ns, Timer=TSC
  [Host]     : .NET Framework 4.6 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2115.0
  DefaultJob : .NET Framework 4.6 (CLR 4.0.30319.42000), 64bit RyuJIT-v4.7.2115.0


```
|         Type |                                    Method |  Version |             Mean |            Error |           StdDev |           Median |
|------------- |------------------------------------------ |--------- |-----------------:|-----------------:|-----------------:|-----------------:|
|        Basic |            Container.Resolve<Container>() | Unity.V4 |         461.1 ns |         3.544 ns |         2.960 ns |         459.8 ns |
|        Basic |            Container.Resolve<Container>() | Unity.V5 |         740.1 ns |         6.735 ns |         5.971 ns |         739.1 ns |
|        Basic |            Container.Resolve<Container>() | Unity.V6 |         476.5 ns |         5.089 ns |         4.511 ns |         474.8 ns |
|        Basic |            Container.Resolve<Container>() |   VS_MEF |       2,944.6 ns |        58.669 ns |       167.387 ns |       2,857.0 ns |
|        Basic |                         'new Container()' | Unity.V4 |       6,673.2 ns |        69.736 ns |        65.231 ns |       6,681.7 ns |
|        Basic |                         'new Container()' | Unity.V5 |       3,379.3 ns |         5.522 ns |         4.895 ns |       3,380.2 ns |
|        Basic |                         'new Container()' | Unity.V6 |       3,462.5 ns |        63.631 ns |        59.521 ns |       3,464.8 ns |
|        Basic |                         'new Container()' |   VS_MEF |      57,344.7 ns |       202.490 ns |       169.088 ns |      57,329.4 ns |
|        Basic |       'using(var uc = new Container()){}' | Unity.V4 |       6,857.0 ns |        73.355 ns |        68.617 ns |       6,846.1 ns |
|        Basic |       'using(var uc = new Container()){}' | Unity.V5 |       3,642.1 ns |        52.423 ns |        43.776 ns |       3,630.5 ns |
|        Basic |       'using(var uc = new Container()){}' | Unity.V6 |       3,746.0 ns |        49.694 ns |        44.053 ns |       3,735.8 ns |
|        Basic |       'using(var uc = new Container()){}' |   VS_MEF |      58,331.0 ns |     1,223.152 ns |     1,144.137 ns |      57,768.0 ns |
|    MultiType |                  'Multiple Registrations' | Unity.V4 | 161,901,905.2 ns | 1,224,656.299 ns | 1,085,625.804 ns | 161,828,787.5 ns |
|    MultiType |                  'Multiple Registrations' | Unity.V5 | 220,077,348.8 ns | 2,249,545.683 ns | 2,104,226.223 ns | 219,718,961.7 ns |
|    MultiType |                  'Multiple Registrations' | Unity.V6 | 218,801,943.3 ns | 2,687,571.999 ns | 2,513,956.271 ns | 218,988,744.0 ns |
|    MultiType |                  'Multiple Registrations' |   VS_MEF |               NA |               NA |               NA |               NA |
| Registration |         'Register Named Type (Singleton)' | Unity.V4 |       1,280.6 ns |        23.775 ns |        22.239 ns |       1,282.0 ns |
| Registration |         'Register Named Type (Singleton)' | Unity.V5 |         816.7 ns |        16.314 ns |        22.870 ns |         816.3 ns |
| Registration |         'Register Named Type (Singleton)' | Unity.V6 |         835.2 ns |        16.561 ns |        19.071 ns |         833.0 ns |
| Registration |         'Register Named Type (Singleton)' |   VS_MEF |               NA |               NA |               NA |               NA |
| Registration | 'Register Named Type Mapping (Singleton)' | Unity.V4 |       2,323.0 ns |        31.951 ns |        29.887 ns |       2,319.8 ns |
| Registration | 'Register Named Type Mapping (Singleton)' | Unity.V5 |         959.5 ns |        18.976 ns |        26.602 ns |         946.5 ns |
| Registration | 'Register Named Type Mapping (Singleton)' | Unity.V6 |       1,018.8 ns |        18.334 ns |        17.149 ns |       1,017.2 ns |
| Registration | 'Register Named Type Mapping (Singleton)' |   VS_MEF |               NA |               NA |               NA |               NA |
| Registration |             'Register Named Type Mapping' | Unity.V4 |       1,029.5 ns |        12.992 ns |        11.517 ns |       1,026.3 ns |
| Registration |             'Register Named Type Mapping' | Unity.V5 |         517.9 ns |         2.614 ns |         2.446 ns |         517.7 ns |
| Registration |             'Register Named Type Mapping' | Unity.V6 |         532.4 ns |         7.019 ns |         6.565 ns |         532.0 ns |
| Registration |             'Register Named Type Mapping' |   VS_MEF |               NA |               NA |               NA |               NA |
| Registration |                     'Register Named Type' | Unity.V4 |         204.7 ns |         3.261 ns |         3.050 ns |         205.1 ns |
| Registration |                     'Register Named Type' | Unity.V5 |         333.9 ns |         5.662 ns |         5.297 ns |         331.7 ns |
| Registration |                     'Register Named Type' | Unity.V6 |         334.8 ns |         3.898 ns |         3.646 ns |         335.0 ns |
| Registration |                     'Register Named Type' |   VS_MEF |               NA |               NA |               NA |               NA |
| Registration |               'Register Type (Singleton)' | Unity.V4 |       1,239.2 ns |         9.167 ns |         8.126 ns |       1,236.8 ns |
| Registration |               'Register Type (Singleton)' | Unity.V5 |         758.9 ns |        19.596 ns |        18.330 ns |         750.8 ns |
| Registration |               'Register Type (Singleton)' | Unity.V6 |         762.6 ns |        15.168 ns |        21.263 ns |         752.3 ns |
| Registration |               'Register Type (Singleton)' |   VS_MEF |               NA |               NA |               NA |               NA |
| Registration |       'Register Type Mapping (Singleton)' | Unity.V4 |       2,258.3 ns |        33.669 ns |        31.494 ns |       2,258.3 ns |
| Registration |       'Register Type Mapping (Singleton)' | Unity.V5 |         900.9 ns |        11.581 ns |         9.671 ns |         896.6 ns |
| Registration |       'Register Type Mapping (Singleton)' | Unity.V6 |         972.3 ns |        19.303 ns |        26.423 ns |         961.6 ns |
| Registration |       'Register Type Mapping (Singleton)' |   VS_MEF |               NA |               NA |               NA |               NA |
| Registration |                   'Register Type Mapping' | Unity.V4 |       1,019.9 ns |         3.855 ns |         2.787 ns |       1,019.8 ns |
| Registration |                   'Register Type Mapping' | Unity.V5 |         491.7 ns |         6.150 ns |         5.452 ns |         492.1 ns |
| Registration |                   'Register Type Mapping' | Unity.V6 |         490.8 ns |         5.459 ns |         4.839 ns |         490.0 ns |
| Registration |                   'Register Type Mapping' |   VS_MEF |               NA |               NA |               NA |               NA |
| Registration |                           'Register Type' | Unity.V4 |         193.7 ns |         1.485 ns |         1.389 ns |         193.3 ns |
| Registration |                           'Register Type' | Unity.V5 |         315.7 ns |         1.723 ns |         1.345 ns |         316.1 ns |
| Registration |                           'Register Type' | Unity.V6 |         354.9 ns |         3.998 ns |         3.740 ns |         354.7 ns |
| Registration |                           'Register Type' |   VS_MEF |               NA |               NA |               NA |               NA |

