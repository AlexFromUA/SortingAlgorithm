// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    public class Comb
    {
        static void Main(string[] args)
        {
            var array = new int[10];
            
            Console.WriteLine($"Unsorted array: {string.Join(',', FillArray(array))}");
            Console.WriteLine($"Sorted array {string.Join(',', CombSort(array))}");
        }
        
        static int[] FillArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 51);
            }

            return array;
        }
        
        public static int[] CombSort(int[] array)
        {
            var gap = array.Length;

            while (gap != 1)
            {
                if (gap > 1)
                {
                    gap = (int)(gap / 1.3);
                }
                else
                {
                    gap = 1;
                }

                for (var i = gap; i < array.Length; i++)
                {
                    if (array[i - gap] > array[i])
                    {
                        Swap(ref array[i - gap], ref array[i]);
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