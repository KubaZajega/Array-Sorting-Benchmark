namespace AlgorytmyStrukturyDanych;

public static class Generators
{
    public static int[] GenerateRandom(int size, int minVal, int maxVal)
    {
        int[] a = new int[size];
        for (int i = 0; i < size; i++)
        {
            a[i] = new Random().Next(minVal, maxVal);
        }
        return a;
    }
    
    public static int[] GenerateSorted(int size, int minVal, int maxVal)
    {
        int[] a = GenerateRandom(size, minVal, maxVal);
        Array.Sort(a);
        return a;
    }
    
    public static int[] GenerateReversed(int size, int minVal, int maxVal)
    {
        int[] a = GenerateSorted(size, minVal, maxVal);
        Array.Reverse(a);
        return a;
    }
    
    public static int[] GenerateAlmostSorted(int size, int minVal, int maxVal)
    {
        int[] a = GenerateSorted(size, minVal, maxVal);
        Random random = new Random();
        int i = random.Next(0, size);
        int j = random.Next(0, size);
        (a[i], a[j]) = (a[j], a[i]);
        return a;
    }
    public static int[] GenerateFewUnique(int size, int minVal, int maxVal)
    {
        int[] a = new int[size];
        Random random = new Random();
        int uniqueCount = Math.Max(1, size / 10);
        int[] uniqueValues = new int[uniqueCount];
        
        for (int i = 0; i < uniqueCount; i++)
        {
            uniqueValues[i] = random.Next(minVal, maxVal);
        }
        
        for (int i = 0; i < size; i++)
        {
            a[i] = uniqueValues[random.Next(0, uniqueCount)];
        }

        return a;
    }
}