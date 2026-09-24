```text
```
| Method                   | Iterations | Mean              | Error             | StdDev             | Median            | Gen0          | Gen1          | Gen2          | Allocated       |
|------------------------- |----------- |------------------:|------------------:|-------------------:|------------------:|--------------:|--------------:|--------------:|----------------:|
| BuildScheduleReport      | 100        |         29.968 us |         0.3141 us |          0.2938 us |         29.925 us |       34.8206 |        0.7935 |             - |       426.45 KB |
| ReportUsingStringBuilder | 100        |          1.728 us |         0.2023 us |          0.5964 us |          1.868 us |        1.6174 |        0.0696 |             - |        19.81 KB |
| BuildScheduleReport      | 1000       |      2,320.852 us |        27.8034 us |         23.2171 us |      2,326.243 us |     3625.0000 |      675.7813 |      324.2188 |     42058.59 KB |
| ReportUsingStringBuilder | 1000       |         63.935 us |         3.7682 us |         10.5042 us |         67.989 us |       26.9775 |       26.9775 |       26.9775 |       169.01 KB |
| BuildScheduleReport      | 10000      |    447,725.669 us |     8,923.1183 us |      8,763.6953 us |    447,495.550 us |  1039000.0000 |  1036000.0000 |  1036000.0000 |   4200203.07 KB |
| ReportUsingStringBuilder | 10000      |        614.173 us |        33.2376 us |         91.5461 us |        646.312 us |      249.5117 |      249.5117 |      249.5117 |      1694.01 KB |
| BuildScheduleReport      | 100000     | 97,317,226.451 us | 7,256,199.5519 us | 21,395,069.6485 us | 83,146,883.500 us | 28009000.0000 | 27989000.0000 | 27989000.0000 | 419936704.93 KB |
| ReportUsingStringBuilder | 100000     |      8,500.593 us |       168.8884 us |        313.0455 us |      8,473.863 us |     1375.0000 |     1351.5625 |      687.5000 |        16853 KB |
```



1) Which approach was faster with 100 iterations?
Answer:  
StringBuilder was faster.  
It completed 100 iterations in 1.728 µs, while the normal string concatenation took 29.968 µs.

2) Which approach was faster with 100,000 iterations?
Answer:  
StringBuilder was dramatically faster.  
StringBuilder finished in 8,500 µs, while string concatenation took 97,317,226 µs (about 97 seconds).

3) Which approach allocated more memory?
Answer:  
String concatenation allocated far more memory.  
At 100,000 iterations, string concatenation allocated 419,936,704 KB, while StringBuilder allocated only 16,853 KB.

4) What happened to string concatenation performance as the loop size increased?
Answer:  
Its performance collapsed as the loop size increased.
Execution time grew from microseconds to tens of seconds, and memory usage exploded from kilobytes to hundreds of gigabytes.
String concatenation became unusable at large iteration counts.

5) Why does repeated string concatenation create additional allocations?
Answer:  
Because strings are immutable in C#.
Every time you Create a new string

Copy the old content

Append the new content

Allocate new memory

Discard the old string

This causes massive memory allocations inside large loops.

6) Why does StringBuilder usually perform better when text is repeatedly appended?
Answer:  
StringBuilder uses a mutable internal buffer, so it does not create a new string every time.
It:

-Reuses the same memory

-Avoids repeated allocations

-Reduces pressure on the garbage collector

-Appends text efficiently inside loops

This makes it much faster and more memory‑efficient for repeated appends.

7) Is StringBuilder always better than normal string operations? Explain.
Answer:  
No, StringBuilder is not always better.

StringBuilder is better when:

You append text many times

You build large strings

You work inside loops

Performance matters

Normal string operations are better when:

The text is small

You only concatenate a few times

Readability is more important

There is no loop or repeated append

For small operations, using StringBuilder adds unnecessary complexity.

```