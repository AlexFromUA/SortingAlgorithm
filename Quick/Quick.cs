// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    public class Quick
    {
        static void Main(string[] args)
        {
            var array = new int[20];
            
            Console.WriteLine($"Unsorted array: {string.Join(',', FillArray(array))}");
            var sortedArray = QuickSort(array, 0, array.Length - 1);
            Console.WriteLine($"Sorted array {string.Join(',', sortedArray)}");
            
        }
        
        static int[] FillArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 51);
            }

            return array;
        }
        
        public static int[] QuickSort(int[] array, int initialIndex, int lastIndex)
        {
            if (initialIndex < lastIndex)
            {
                int pivotIndex = Partition(array, initialIndex, lastIndex);
                QuickSort(array, initialIndex, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, lastIndex);
            }

            return array;
        }

        static int Partition(int[] array, int initialIndex, int lastIndex)
        {
            var pivotIndex = initialIndex - 1;

            for (var i = initialIndex; i < lastIndex; i++)
            {
                var a = array[i];
                var b = array[lastIndex];
                if (array[i] < array[lastIndex])
                {
                    pivotIndex++;
                    var c = array[pivotIndex];
                    Swap(ref array[i], ref array[pivotIndex]);
                }
            }

            pivotIndex++;
            Swap(ref array[pivotIndex], ref array[lastIndex]);

            return pivotIndex;
        }

        static void Swap(ref int leftItem, ref int rightItem)
        {
            var temp = leftItem;
            leftItem = rightItem;
            rightItem = temp;
        }
    }
};