```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22621.2134/22H2/2022Update/SunValley2)
AMD Ryzen 9 5900X, 1 CPU, 24 logical and 12 physical cores
.NET SDK 7.0.306
  [Host]     : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.10 (7.0.1023.36312), X64 RyuJIT AVX2


```
|                                  Method |      Mean |     Error |    StdDev |    Median |   Gen0 | Allocated |
|---------------------------------------- |----------:|----------:|----------:|----------:|-------:|----------:|
|                          Record1WithAll | 3.4821 ns | 0.0111 ns | 0.0098 ns | 3.4826 ns | 0.0014 |      24 B |
|                   Record1ConstructorAll | 2.6228 ns | 0.0290 ns | 0.0227 ns | 2.6251 ns | 0.0014 |      24 B |
|                    RecordStruct1WithAll | 0.0061 ns | 0.0025 ns | 0.0023 ns | 0.0065 ns |      - |         - |
|             RecordStruct1ConstructorAll | 0.0008 ns | 0.0011 ns | 0.0011 ns | 0.0003 ns |      - |         - |
|            RecordStructReadonly1WithAll | 0.0040 ns | 0.0019 ns | 0.0018 ns | 0.0042 ns |      - |         - |
|     RecordStructReadonly1ConstructorAll | 0.0009 ns | 0.0010 ns | 0.0008 ns | 0.0011 ns |      - |         - |
|                         Record5WithHalf | 9.5052 ns | 0.2546 ns | 0.7507 ns | 9.4989 ns | 0.0024 |      40 B |
|                        Record5WithDense | 4.3245 ns | 0.0270 ns | 0.0252 ns | 4.3284 ns | 0.0024 |      40 B |
|                          Record5WithAll | 4.0022 ns | 0.0289 ns | 0.0271 ns | 4.0021 ns | 0.0024 |      40 B |
|                  Record5ConstructorHalf | 3.1798 ns | 0.0299 ns | 0.0280 ns | 3.1753 ns | 0.0024 |      40 B |
|                 Record5ConstructorDense | 3.2178 ns | 0.0279 ns | 0.0261 ns | 3.2171 ns | 0.0024 |      40 B |
|                   Record5ConstructorAll | 2.9336 ns | 0.0349 ns | 0.0326 ns | 2.9334 ns | 0.0024 |      40 B |
|                   RecordStruct5WithHalf | 3.7840 ns | 0.0144 ns | 0.0135 ns | 3.7909 ns |      - |         - |
|                  RecordStruct5WithDense | 3.9899 ns | 0.0157 ns | 0.0147 ns | 3.9979 ns |      - |         - |
|                    RecordStruct5WithAll | 4.0000 ns | 0.0155 ns | 0.0145 ns | 4.0077 ns |      - |         - |
|            RecordStruct5ConstructorHalf | 4.2072 ns | 0.0174 ns | 0.0162 ns | 4.2131 ns |      - |         - |
|           RecordStruct5ConstructorDense | 4.2027 ns | 0.0183 ns | 0.0172 ns | 4.2106 ns |      - |         - |
|             RecordStruct5ConstructorAll | 4.0008 ns | 0.0179 ns | 0.0168 ns | 4.0076 ns |      - |         - |
|           RecordStructReadonly5WithHalf | 3.9405 ns | 0.0987 ns | 0.1175 ns | 3.9119 ns |      - |         - |
|          RecordStructReadonly5WithDense | 4.3436 ns | 0.0269 ns | 0.0251 ns | 4.3482 ns |      - |         - |
|            RecordStructReadonly5WithAll | 4.3517 ns | 0.0255 ns | 0.0239 ns | 4.3396 ns |      - |         - |
|    RecordStructReadonly5ConstructorHalf | 4.5452 ns | 0.0246 ns | 0.0231 ns | 4.5443 ns |      - |         - |
|   RecordStructReadonly5ConstructorDense | 4.2131 ns | 0.0169 ns | 0.0158 ns | 4.2211 ns |      - |         - |
|     RecordStructReadonly5ConstructorAll | 4.0045 ns | 0.0208 ns | 0.0195 ns | 4.0156 ns |      - |         - |
|                         Record8WithHalf | 4.4365 ns | 0.0147 ns | 0.0137 ns | 4.4382 ns | 0.0029 |      48 B |
|                        Record8WithDense | 4.4652 ns | 0.0133 ns | 0.0124 ns | 4.4653 ns | 0.0029 |      48 B |
|                          Record8WithAll | 4.8379 ns | 0.0087 ns | 0.0072 ns | 4.8398 ns | 0.0029 |      48 B |
|                  Record8ConstructorHalf | 3.5070 ns | 0.0140 ns | 0.0131 ns | 3.5051 ns | 0.0029 |      48 B |
|                 Record8ConstructorDense | 3.3372 ns | 0.0149 ns | 0.0139 ns | 3.3385 ns | 0.0029 |      48 B |
|                   Record8ConstructorAll | 3.2537 ns | 0.0158 ns | 0.0148 ns | 3.2487 ns | 0.0029 |      48 B |
|                   RecordStruct8WithHalf | 5.4228 ns | 0.0162 ns | 0.0151 ns | 5.4237 ns |      - |         - |
|                  RecordStruct8WithDense | 3.7989 ns | 0.0037 ns | 0.0035 ns | 3.7978 ns |      - |         - |
|                    RecordStruct8WithAll | 4.5903 ns | 0.0139 ns | 0.0130 ns | 4.5954 ns |      - |         - |
|            RecordStruct8ConstructorHalf | 4.6274 ns | 0.0193 ns | 0.0171 ns | 4.6339 ns |      - |         - |
|           RecordStruct8ConstructorDense | 4.8571 ns | 0.0132 ns | 0.0123 ns | 4.8610 ns |      - |         - |
|             RecordStruct8ConstructorAll | 4.5821 ns | 0.0152 ns | 0.0143 ns | 4.5910 ns |      - |         - |
|           RecordStructReadonly8WithHalf | 5.4224 ns | 0.0166 ns | 0.0155 ns | 5.4287 ns |      - |         - |
|          RecordStructReadonly8WithDense | 3.7864 ns | 0.0126 ns | 0.0118 ns | 3.7894 ns |      - |         - |
|            RecordStructReadonly8WithAll | 4.8503 ns | 0.0161 ns | 0.0150 ns | 4.8565 ns |      - |         - |
|    RecordStructReadonly8ConstructorHalf | 4.6247 ns | 0.0216 ns | 0.0202 ns | 4.6275 ns |      - |         - |
|   RecordStructReadonly8ConstructorDense | 4.8579 ns | 0.0260 ns | 0.0243 ns | 4.8639 ns |      - |         - |
|     RecordStructReadonly8ConstructorAll | 4.5960 ns | 0.0129 ns | 0.0120 ns | 4.5978 ns |      - |         - |
|                      Record13WithSparse | 6.1747 ns | 0.0362 ns | 0.0339 ns | 6.1764 ns | 0.0043 |      72 B |
|                        Record13WithHalf | 6.5044 ns | 0.0355 ns | 0.0332 ns | 6.5064 ns | 0.0043 |      72 B |
|                       Record13WithDense | 6.7412 ns | 0.0504 ns | 0.0471 ns | 6.7422 ns | 0.0043 |      72 B |
|                         Record13WithAll | 6.9935 ns | 0.0577 ns | 0.0540 ns | 7.0070 ns | 0.0043 |      72 B |
|               Record13ConstructorSparse | 7.1270 ns | 0.0409 ns | 0.0382 ns | 7.1286 ns | 0.0043 |      72 B |
|                 Record13ConstructorHalf | 5.3447 ns | 0.0259 ns | 0.0242 ns | 5.3541 ns | 0.0043 |      72 B |
|                Record13ConstructorDense | 4.3330 ns | 0.0263 ns | 0.0246 ns | 4.3339 ns | 0.0043 |      72 B |
|                  Record13ConstructorAll | 4.2269 ns | 0.0796 ns | 0.0621 ns | 4.2175 ns | 0.0043 |      72 B |
|                RecordStruct13WithSparse | 4.2729 ns | 0.0054 ns | 0.0048 ns | 4.2735 ns |      - |         - |
|                  RecordStruct13WithHalf | 4.6411 ns | 0.0427 ns | 0.0333 ns | 4.6383 ns |      - |         - |
|                 RecordStruct13WithDense | 5.1266 ns | 0.0218 ns | 0.0204 ns | 5.1343 ns |      - |         - |
|                   RecordStruct13WithAll | 5.2776 ns | 0.0212 ns | 0.0199 ns | 5.2838 ns |      - |         - |
|         RecordStruct13ConstructorSparse | 6.3098 ns | 0.0353 ns | 0.0330 ns | 6.3189 ns |      - |         - |
|           RecordStruct13ConstructorHalf | 5.4644 ns | 0.0189 ns | 0.0177 ns | 5.4711 ns |      - |         - |
|          RecordStruct13ConstructorDense | 5.8773 ns | 0.0257 ns | 0.0241 ns | 5.8831 ns |      - |         - |
|            RecordStruct13ConstructorAll | 5.0333 ns | 0.0266 ns | 0.0249 ns | 5.0438 ns |      - |         - |
|        RecordStructReadonly13WithSparse | 5.4863 ns | 0.0250 ns | 0.0234 ns | 5.4960 ns |      - |         - |
|          RecordStructReadonly13WithHalf | 4.6379 ns | 0.0166 ns | 0.0155 ns | 4.6443 ns |      - |         - |
|         RecordStructReadonly13WithDense | 5.0529 ns | 0.0247 ns | 0.0231 ns | 5.0621 ns |      - |         - |
|           RecordStructReadonly13WithAll | 5.2729 ns | 0.0218 ns | 0.0204 ns | 5.2819 ns |      - |         - |
| RecordStructReadonly13ConstructorSparse | 6.3922 ns | 0.0161 ns | 0.0143 ns | 6.3948 ns |      - |         - |
|   RecordStructReadonly13ConstructorHalf | 5.4532 ns | 0.0297 ns | 0.0278 ns | 5.4552 ns |      - |         - |
|  RecordStructReadonly13ConstructorDense | 5.8863 ns | 0.0255 ns | 0.0239 ns | 5.8883 ns |      - |         - |
|    RecordStructReadonly13ConstructorAll | 5.7882 ns | 0.0370 ns | 0.0346 ns | 5.7797 ns |      - |         - |
