// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    public static class Bubble
    {
        static void Main(string[] args)
        {
            var array = new int[20];
            
            Console.WriteLine($"Unsorted array: {string.Join(',', FillArray(array))}");
            Console.WriteLine($"Sorted array {string.Join(',', BubbleSort(array))}");
        }
        
        static int[] FillArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 51);
            }

            return array;
        }
        
        public static int[] BubbleSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                for (var j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap( ref array[j],  ref array[j + 1]);
                    }
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