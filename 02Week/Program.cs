using _02Week;
using System;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Exercises ex = new Exercises();
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        string[] names = File.ReadAllLines("names.txt");
        for (int i = 0; i < names.Length; i++)
        {
            names[i] = names[i].ToLower();
        }
        //foreach(string name in ex.BubbleSort(names))
        //{
        //    Console.WriteLine(name);
        //}
        //CountingSortAlgorithm(names);
        ShellSort(names);
        Console.WriteLine(string.Join(", ", names));
        long memoryUsed = GC.GetTotalMemory(true);
        Console.WriteLine($"Memory Used: {memoryUsed} bytes");
        stopwatch.Stop();
        TimeSpan elapsedTime = stopwatch.Elapsed;
        Console.WriteLine($"Execution Time: {elapsedTime.TotalMilliseconds} ms");


    }
    static void Selection(string[] names)
    {
        for (int i = 0; i < names.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < names.Length; j++)
            {
                if (string.Compare(names[j], names[minIndex]) < 0)
                {
                    minIndex = j;
                }
            }

            // Swap arr[i] and arr[minIndex]
            string temp = names[i];
            names[i] = names[minIndex];
            names[minIndex] = temp;
        }
    }
        static void Insertion(string[] names)
    {
        for (int i = 1; i < names.Length; i++)
        {
            string current = names[i];
            int j = i - 1;

            while (j >= 0 && string.Compare(names[j], current) > 0)
            {
                names[j + 1] = names[j];
                j--;
            }

            names[j + 1] = current;
        }

    }
    static void CountingSortAlgorithm(string[] names)
    {
        int n = names.Length;
        string[] output = new string[n];

        
        int[] count = new int[26];

        
        for (int i = 0; i < n; i++)
        {
            string name = names[i];
            char firstChar = name[0];
            int index = firstChar - 'a';
            count[index]++;
        }

      
        for (int i = 1; i < 26; i++)
        {
            count[i] += count[i - 1];
        }

        
        for (int i = n - 1; i >= 0; i--)
        {
            string name = names[i];
            char firstChar = name[0];
            int index = firstChar - 'a';
            int position = count[index] - 1;
            output[position] = name;
            count[index]--;
        }

        
        Array.Copy(output, names, n);
    }
    static void ShellSort(string[] names)
    {
        int n = names.Length;
        int gap = n / 2; 

        while (gap > 0)
        {
            for (int i = gap; i < n; i++)
            {
                string temp = names[i];
                int j = i;

                while (j >= gap && string.Compare(names[j - gap], temp) > 0)
                {
                    names[j] = names[j - gap];
                    j -= gap;
                }

                names[j] = temp;
            }

            gap /= 2;
        }
    }
    static void MySort(string[] names)
    {
            
    }
}