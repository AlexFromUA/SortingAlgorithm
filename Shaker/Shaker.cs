// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    public class Shaker
    {
        static void Main(string[] args)
        {
            var array = new int[10];
            
            Console.WriteLine($"Unsorted array: {string.Join(',', FillArray(array))}");
            Console.WriteLine($"Sorted array {string.Join(',', ShakerSort(array))}");
        }
        
        static int[] FillArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 51);
            }

            return array;
        }
        
        public static int[] ShakerSort(int[] array)
        {
            var leftBorder = 0;
            var rightBorder = array.Length - 1;

            while (true)
            {
                if (leftBorder >= rightBorder)
                {
                    break;
                }

                for (var i = leftBorder; i < rightBorder; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(ref array[i], ref array[i + 1]);
                    }
                }
                rightBorder--;

                for (var i = rightBorder - 1; i > leftBorder; i--)
                {
                    if (array[i] < array[i - 1])
                    {
                        Swap(ref array[i], ref array[i - 1]);
                    }
                }
                leftBorder++;
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