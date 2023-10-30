// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    public class PanCake
    {
        static void Main(string[] args)
        {
            var array = new int[10];
            
            Console.WriteLine($"Unsorted array: {string.Join(',', FillArray(array))}");
            Console.WriteLine($"Sorted array {string.Join(',', PancakeSort(array))}");
        }
        
        static int[] FillArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 51);
            }

            return array;
        }
        
        static int GetIndexOfMax(int[] array, int indexOfLast)
        {
            var indexOfMax = 0;

            for (var i = 0; i <= indexOfLast; i++)
            {
                if (array[i] > array[indexOfMax])
                {
                    indexOfMax = i;
                }
            }

            return indexOfMax;
        }

        static int[] FlipArray(int[] array, int indexOfLast)
        {
            for (var i = 0; i < indexOfLast; i++, indexOfLast--)
            {
                Swap(ref array[i], ref array[indexOfLast]);
            }

            return array;
        }

        public static int[] PancakeSort(int[] array)
        {
            var indexOfLast = array.Length - 1;
            while (indexOfLast > 0)
            {
                var indexOfMax = GetIndexOfMax(array, indexOfLast);
                if (indexOfMax != indexOfLast)
                {
                    FlipArray(array, indexOfMax);
                    FlipArray(array, indexOfLast);
                } 
                
                indexOfLast--;
            }

            return array;
        }

        static void Swap(ref int leftItem, ref int rightItem)
        {
            var temp = leftItem;
            leftItem = rightItem;
            rightItem = temp;
        }
    }
};