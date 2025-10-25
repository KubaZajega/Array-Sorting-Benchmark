# Array Sorting Benchmark

## 📌 About the project

This project benchmarks various array sorting algorithms using BenchmarkDotNet. The tests were conducted on an Apple M4 running macOS Sequoia 15.3.1 and .NET 9.0.2.

## 📊 Results

| Method                                  | Mean            | Error        | StdDev       | Gen0      | Gen1     | Gen2     | Allocated  |
|---------------------------------------- |----------------:|-------------:|-------------:|----------:|---------:|---------:|-----------:|
| SortArrayRandom                         |       536.13 μs |     3.027 μs |     2.832 μs |         - |        - |        - |        1 B |
| SortArrayUsingInsertionSortRandom       |        62.76 μs |     0.147 μs |     0.137 μs |         - |        - |        - |          - |
| SortArrayUsingMergeSortRandom           |     2,674.14 μs |    29.104 μs |    27.224 μs | 1582.0313 | 230.4688 | 230.4688 | 12131806 B |
| SortArrayUsingQuickSortRandom           | 1,217,320.21 μs | 6,063.568 μs | 5,671.865 μs |         - |        - |        - |        4 B |
| SortArraySorted                         |       548.57 μs |    10.844 μs |    10.650 μs |         - |        - |        - |        1 B |
| SortArrayUsingInsertionSortSorted       |        63.59 μs |     0.472 μs |     0.394 μs |         - |        - |        - |          - |
| SortArrayUsingMergeSortSorted           |     2,705.84 μs |    37.706 μs |    35.270 μs | 1582.0313 | 230.4688 | 230.4688 | 12131802 B |
| SortArrayUsingQuickSortSorted           | 1,213,129.70 μs | 1,708.561 μs | 1,426.726 μs |         - |        - |        - |       46 B |
| SortArrayReversed                       |       491.66 μs |     1.441 μs |     1.348 μs |         - |        - |        - |          - |
| SortArrayUsingInsertionSortReversed     |        63.17 μs |     0.053 μs |     0.047 μs |         - |        - |        - |          - |
| SortArrayUsingMergeSortReversed         |     2,726.51 μs |    22.667 μs |    20.093 μs | 1582.0313 | 230.4688 | 230.4688 | 12131758 B |
| SortArrayUsingQuickSortReversed         | 1,227,522.89 μs | 1,904.459 μs | 1,781.432 μs |         - |        - |        - |      736 B |
| SortArrayAlmostSorted                   |       484.86 μs |     0.680 μs |     0.603 μs |         - |        - |        - |          - |
| SortArrayUsingInsertionSortAlmostSorted |        63.15 μs |     0.036 μs |     0.033 μs |         - |        - |        - |          - |
| SortArrayUsingMergeSortAlmostSorted     |     2,685.37 μs |    13.789 μs |    12.899 μs | 1582.0313 | 230.4688 | 230.4688 | 12131780 B |
| SortArrayUsingQuickSortAlmostSorted     | 1,234,089.50 μs | 2,049.324 μs | 1,916.939 μs |         - |        - |        - |      736 B |
| SortArrayFewUnique                      |       490.36 μs |     1.433 μs |     1.341 μs |         - |        - |        - |          - |
| SortArrayFewUniqueUsingInsertionSort    |        63.16 μs |     0.081 μs |     0.067 μs |         - |        - |        - |          - |
| SortArrayFewUniqueUsingMergeSort        |     2,929.83 μs |    39.301 μs |    36.762 μs | 1582.0313 | 230.4688 | 230.4688 | 12131769 B |
| SortArrayFewUniqueUsingQuickSort        | 1,213,789.98 μs | 3,116.912 μs | 2,915.561 μs |         - |        - |        - |      736 B |


## 🛠 Technologies

- .NET 9.0.2
- BenchmarkDotNet
- macOS Sequoia 15.3.1

