// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    public class Insertion
    {
        static void Main(string[] args)
        {
            var array = new int[10];
            
            Console.WriteLine($"Unsorted array: {string.Join(',', FillArray(array))}");
            Console.WriteLine($"Sorted array {string.Join(',', InsertionSort(array))}");
        }
        
        static int[] FillArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 51);
            }

            return array;
        }
        
        public static int[] InsertionSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                for (var j = i; j > 0 && array[j - 1] > array[j]; j--)
                {
                    Swap(ref array[j - 1], ref array[j]);
                }
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