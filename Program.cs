// .Net9, C#13
using System;
using System.Linq;
using AlgorytmyStrukturyDanych;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

// Main
var summary = BenchmarkRunner.Run<ArraySortingBenchmark>();
Console.WriteLine(summary);


// Benchmark class

[MemoryDiagnoser]
public class ArraySortingBenchmark
{
    private int[] arraySmallRandom = [];
    private int[] arrayMediumRandom = [];
    private int[] arrayLargeRandom = [];
    
    private int[] arraySmallSorted = [];
    private int[] arrayMediumSorted = [];
    private int[] arrayLargeSorted = [];
    
    private int[] arraySmallReversed = [];
    private int[] arrayMediumReversed = [];
    private int[] arrayLargeReversed = [];
    
    private int[] arraySmallAlmostSorted = [];
    private int[] arrayMediumAlmostSorted = [];
    private int[] arrayLargeAlmostSorted = [];
    
    private int[] arraySmallFewUnique = [];
    private int[] arrayMediumFewUnique = [];
    private int[] arrayLargeFewUnique = [];
    
    private int sizeSmall = 100;
    private int sizeMedium = 1000;
    private int sizeLarge = 100000;

    SortingAlgorithms.InsertionSort ob1 = new SortingAlgorithms.InsertionSort();
    SortingAlgorithms.MergeSort ob2 = new SortingAlgorithms.MergeSort();
    SortingAlgorithms.QuickSort ob3 = new SortingAlgorithms.QuickSort();

    [GlobalSetup]
    public void Setup()
    {
        arraySmallRandom = new int[sizeSmall];
        arrayMediumRandom = new int[sizeMedium];
        arrayLargeRandom = new int[sizeLarge];
        
        arraySmallSorted = new int[sizeSmall];
        arrayMediumSorted = new int[sizeMedium];
        arrayLargeSorted = new int[sizeLarge];
        
        arraySmallRandom = Generators.GenerateRandom(sizeSmall,0, arraySmallRandom.Length);
        arrayMediumRandom = Generators.GenerateRandom(sizeMedium,0, arrayMediumRandom.Length);
        arrayLargeRandom = Generators.GenerateRandom(sizeLarge,0, arrayLargeRandom.Length);
        
        arraySmallSorted = Generators.GenerateRandom(sizeSmall,0, arraySmallSorted.Length);
        arrayMediumSorted = Generators.GenerateRandom(sizeMedium,0, arrayMediumSorted.Length);
        arrayLargeSorted = Generators.GenerateRandom(sizeLarge,0, arrayLargeSorted.Length);
        
        arraySmallReversed = Generators.GenerateReversed(sizeSmall,0, arraySmallReversed.Length);
        arrayMediumReversed = Generators.GenerateReversed(sizeMedium,0, arrayMediumReversed.Length);
        arrayLargeReversed = Generators.GenerateReversed(sizeLarge,0, arrayLargeReversed.Length);
        
        arraySmallAlmostSorted = Generators.GenerateAlmostSorted(sizeSmall,0, arraySmallAlmostSorted.Length);
        arrayMediumAlmostSorted = Generators.GenerateAlmostSorted(sizeMedium,0, arrayMediumAlmostSorted.Length);
        arrayLargeAlmostSorted = Generators.GenerateAlmostSorted(sizeLarge,0, arrayLargeAlmostSorted.Length);
        
        arraySmallFewUnique = Generators.GenerateFewUnique(sizeSmall,0, arraySmallFewUnique.Length);
        arrayMediumFewUnique = Generators.GenerateFewUnique(sizeMedium,0, arrayMediumFewUnique.Length);
        arrayLargeFewUnique = Generators.GenerateFewUnique(sizeLarge,0, arrayLargeFewUnique.Length);
        
    }

    [Benchmark]
    public void SortArrayRandom()
    {
        Array.Sort(arraySmallRandom);
        Array.Sort(arrayMediumRandom);
        Array.Sort(arrayLargeRandom);
    }

    [Benchmark]
    public void SortArrayUsingInsertionSortRandom()
    {
        ob1.sort(arraySmallRandom);
        ob1.sort(arrayMediumRandom);
        ob1.sort(arrayLargeRandom);
    }
    [Benchmark]
    public void SortArrayUsingMergeSortRandom()
    {
        ob2.sort(arraySmallRandom, 0, arraySmallRandom.Length - 1);
        ob2.sort(arrayMediumRandom, 0, arrayMediumRandom.Length - 1);
        ob2.sort(arrayLargeRandom, 0, arrayLargeRandom.Length - 1);
    }
    [Benchmark]
    public void SortArrayUsingQuickSortRandom()
    {
        ob3.sort(arraySmallRandom, 0, arraySmallRandom.Length - 1);
        ob3.sort(arrayMediumRandom, 0, arrayMediumRandom.Length - 1);
        ob3.sort(arrayLargeRandom, 0, arrayLargeRandom.Length - 1);
    }
    [Benchmark]
    public void SortArraySorted()
    {
        Array.Sort(arraySmallSorted);
        Array.Sort(arrayMediumSorted);
        Array.Sort(arrayLargeSorted);
    }
    [Benchmark]
    public void SortArrayUsingInsertionSortSorted()
    {
        ob1.sort(arraySmallSorted);
        ob1.sort(arrayMediumSorted);
        ob1.sort(arrayLargeSorted);
    }
    [Benchmark]
    public void SortArrayUsingMergeSortSorted()
    {
        ob2.sort(arraySmallSorted, 0, arraySmallSorted.Length - 1);
        ob2.sort(arrayMediumSorted, 0, arrayMediumSorted.Length - 1);
        ob2.sort(arrayLargeSorted, 0, arrayLargeSorted.Length - 1);
    }
    [Benchmark]
    public void SortArrayUsingQuickSortSorted()
    {
        ob3.sort(arraySmallSorted, 0, arraySmallSorted.Length - 1);
        ob3.sort(arrayMediumSorted, 0, arrayMediumSorted.Length - 1);
        ob3.sort(arrayLargeSorted, 0, arrayLargeSorted.Length - 1);
    }
    [Benchmark]
    public void SortArrayReversed()
    {
        Array.Sort(arraySmallReversed);
        Array.Sort(arrayMediumReversed);
        Array.Sort(arrayLargeReversed);
    }
    [Benchmark]
    public void SortArrayUsingInsertionSortReversed()
    {
        ob1.sort(arraySmallReversed);
        ob1.sort(arrayMediumReversed);
        ob1.sort(arrayLargeReversed);
    }
    [Benchmark]
    public void SortArrayUsingMergeSortReversed()
    {
        ob2.sort(arraySmallReversed, 0, arraySmallReversed.Length - 1);
        ob2.sort(arrayMediumReversed, 0, arrayMediumReversed.Length - 1);
        ob2.sort(arrayLargeReversed, 0, arrayLargeReversed.Length - 1);
    }
    [Benchmark]
    public void SortArrayUsingQuickSortReversed()
    {
        ob3.sort(arraySmallReversed, 0, arraySmallReversed.Length - 1);
        ob3.sort(arrayMediumReversed, 0, arrayMediumReversed.Length - 1);
        ob3.sort(arrayLargeReversed, 0, arrayLargeReversed.Length - 1);
    }
    [Benchmark]
    public void SortArrayAlmostSorted()
    {
        Array.Sort(arraySmallAlmostSorted);
        Array.Sort(arrayMediumAlmostSorted);
        Array.Sort(arrayLargeAlmostSorted);
    }
    [Benchmark]
    public void SortArrayUsingInsertionSortAlmostSorted()
    {
        ob1.sort(arraySmallAlmostSorted);
        ob1.sort(arrayMediumAlmostSorted);
        ob1.sort(arrayLargeAlmostSorted);
    }
    [Benchmark]
    public void SortArrayUsingMergeSortAlmostSorted()
    {
        ob2.sort(arraySmallAlmostSorted, 0, arraySmallAlmostSorted.Length - 1);
        ob2.sort(arrayMediumAlmostSorted, 0, arrayMediumAlmostSorted.Length - 1);
        ob2.sort(arrayLargeAlmostSorted, 0, arrayLargeAlmostSorted.Length - 1);
    }
    [Benchmark]
    public void SortArrayUsingQuickSortAlmostSorted()
    {
        ob3.sort(arraySmallAlmostSorted, 0, arraySmallAlmostSorted.Length - 1);
        ob3.sort(arrayMediumAlmostSorted, 0, arrayMediumAlmostSorted.Length - 1);
        ob3.sort(arrayLargeAlmostSorted, 0, arrayLargeAlmostSorted.Length - 1);
    }
    [Benchmark]
    public void SortArrayFewUnique()
    {
        Array.Sort(arraySmallFewUnique);
        Array.Sort(arrayMediumFewUnique);
        Array.Sort(arrayLargeFewUnique);
    }
    [Benchmark]
    public void SortArrayFewUniqueUsingInsertionSort()
    {
        ob1.sort(arraySmallFewUnique);
        ob1.sort(arrayMediumFewUnique);
        ob1.sort(arrayLargeFewUnique);
    }
    [Benchmark]
    public void SortArrayFewUniqueUsingMergeSort()
    {
        ob2.sort(arraySmallFewUnique, 0, arraySmallFewUnique.Length - 1);
        ob2.sort(arrayMediumFewUnique, 0, arrayMediumFewUnique.Length - 1);
        ob2.sort(arrayLargeFewUnique, 0, arrayLargeFewUnique.Length - 1);
    }
    [Benchmark]
    public void SortArrayFewUniqueUsingQuickSort()
    {
        ob3.sort(arraySmallFewUnique, 0, arraySmallFewUnique.Length - 1);
        ob3.sort(arrayMediumFewUnique, 0, arrayMediumFewUnique.Length - 1);
        ob3.sort(arrayLargeFewUnique, 0, arrayLargeFewUnique.Length - 1);
    }
    
    [GlobalCleanup]
    public void Cleanup()
    {
        arraySmallRandom = [];
        arrayMediumRandom = [];
        arrayLargeRandom = [];

        arraySmallSorted = [];
        arrayMediumSorted = [];
        arrayLargeSorted = [];

        arraySmallReversed = [];
        arrayMediumReversed = [];
        arrayLargeReversed = [];

        arraySmallAlmostSorted = [];
        arrayMediumAlmostSorted = [];
        arrayLargeAlmostSorted = [];

        arraySmallFewUnique = [];
        arrayMediumFewUnique = [];
        arrayLargeFewUnique = [];
    }
}