using System.Diagnostics;

namespace ConsoleApp1
{
    public class Comparison
    {
        static void Main(string[] args)
        {
            var bubbleSortArray = new int[1000];
            FillArray(bubbleSortArray);

            var stopWatch = new Stopwatch();
            stopWatch.Start();
            Bubble.BubbleSort(bubbleSortArray);
            stopWatch.Stop();

            Console.WriteLine($"Bubble Sort: {TimeSpan.FromTicks(stopWatch.ElapsedTicks).TotalMilliseconds}");

            stopWatch.Reset();


            var quickSortArray = new int[1000];
            FillArray(quickSortArray);

            stopWatch.Start();
            Quick.QuickSort(quickSortArray, 0, quickSortArray.Length - 1);
            stopWatch.Stop();

            Console.WriteLine($"Quick Sort: {TimeSpan.FromTicks(stopWatch.ElapsedTicks).TotalMilliseconds}");

            stopWatch.Reset();

            var treeSortArray = new int[1000];
            FillArray(treeSortArray);

            stopWatch.Start();
            Tree.TreeSort(treeSortArray);
            stopWatch.Stop();

            Console.WriteLine($"Tree Sort: {TimeSpan.FromTicks(stopWatch.ElapsedTicks).TotalMilliseconds}");

            stopWatch.Reset();

            var shakerSortArray = new int[1000];
            FillArray(shakerSortArray);

            stopWatch.Start();
            Shaker.ShakerSort(shakerSortArray);
            stopWatch.Stop();

            Console.WriteLine($"Shaker Sort: {TimeSpan.FromTicks(stopWatch.ElapsedTicks).TotalMilliseconds}");

            stopWatch.Reset();

            var combSortArray = new int[1000];
            FillArray(combSortArray);

            stopWatch.Start();
            Comb.CombSort(combSortArray);
            stopWatch.Stop();

            Console.WriteLine($"Comb Sort: {TimeSpan.FromTicks(stopWatch.ElapsedTicks).TotalMilliseconds}");

            stopWatch.Reset();

            var insertionSortArray = new int[1000];
            FillArray(insertionSortArray);

            stopWatch.Start();
            Insertion.InsertionSort(insertionSortArray);
            stopWatch.Stop();

            Console.WriteLine($"Insertion Sort: {TimeSpan.FromTicks(stopWatch.ElapsedTicks).TotalMilliseconds}");

            stopWatch.Reset();

            var pancakeSortArray = new int[1000];
            FillArray(pancakeSortArray);

            stopWatch.Start();
            PanCake.PancakeSort(pancakeSortArray);
            stopWatch.Stop();

            Console.WriteLine($"Pancake Sort: {TimeSpan.FromTicks(stopWatch.ElapsedTicks).TotalMilliseconds}");

            stopWatch.Reset();
        }
        
        static int[] FillArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 51);
            }

            return array;
        }
    }
}