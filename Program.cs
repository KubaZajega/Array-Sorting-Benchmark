// .Net9, C#13
using System;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

// Main
var summary = BenchmarkRunner.Run<ArraySortingBenchmark>();
Console.WriteLine(summary);


// Benchmark class

[MemoryDiagnoser]
public class ArraySortingBenchmark
{
    private int[] array = [];

    [GlobalSetup]
    public void Setup()
    {
        var random = new Random();
        array = new int[1000];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 1000);
        }
    }

    [Benchmark]
    public void SortArray()
    {
        Array.Sort(array);
    }

    [Benchmark]
    public void SortArrayUsingLinq()
    {
        array = array.OrderBy(x => x).ToArray();
    }

    [GlobalCleanup]
    public void Cleanup()
    {
        array = [];
    }
}