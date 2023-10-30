// See https://aka.ms/new-console-template for more information

namespace ConsoleApp1
{
    public class Tree
    {
        static void Main(string[] args)
        {
            var array = new int[10];
            
            Console.WriteLine($"Unsorted array: {string.Join(',', FillArray(array))}");
            Console.WriteLine($"Sorted array {string.Join(',', TreeSort(array))}");
        }
        
        static int[] FillArray(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1, 51);
            }

            return array;
        }
        
        public class TreeNode
        {
            public int Data { get; set; }
            public TreeNode Left { get; set; }
            public TreeNode Right { get; set; }

            public TreeNode(int data)
            {
                Data = data;
            }
        }


        public class BinaryTree
        {
            private TreeNode _root;
            
            public void Insert(int data)
            {
                _root = Insert(_root, data);
            }
            private TreeNode Insert(TreeNode node, int data)
            {
                if (node == null)
                {
                    return new TreeNode(data);
                }

                if (node.Data > data)
                {
                    node.Left = Insert(node.Left, data);
                }
                else
                {
                    node.Right = Insert(node.Right, data);
                }

                return node;
            }
        
            public void Sort(int[] array)
            {
                for(var i = 0; i < array.Length; i++)
                {
                    Insert(array[i]);
                }

                var index = 0;
                Sort(array, _root, ref index);
            }

            private void Sort(int[] array, TreeNode node, ref int index)
            {
                if (node != null)
                {
                    Sort(array, node.Left, ref index);
                    array[index] = node.Data;
                    index++;
                    Sort(array, node.Right, ref index);
                }
            }
        }
        
        public static int[] TreeSort(int[] array)
        {
            var binaryTree = new BinaryTree();
            binaryTree.Sort(array);

            return array;
        }
    }
};