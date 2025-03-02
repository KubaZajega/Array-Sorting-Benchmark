// file: BenchmarkStringVersusStringBuilder.cs
using BenchmarkDotNet.Attributes;
    
[MemoryDiagnoser]
public class BenchmarkStringVersusStringBuilder
{
    const int N = 1000;

    [Benchmark]
    public string StringConcatenation()
    {
        string result = string.Empty;
        for (int i = 0; i < N; i++)
            result += i;
        return result;
    }


    [Benchmark]
    public string StringBuilderConcatenation()
    {
        var sb = new System.Text.StringBuilder();

        for (int i = 0; i < N; i++)
            sb.Append(i);

        return sb.ToString();
    }
}