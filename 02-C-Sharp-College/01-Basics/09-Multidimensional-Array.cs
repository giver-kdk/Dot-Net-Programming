using System;

namespace ArrayStructure
{
    public class Program
    {
        public static void PrintArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.WriteLine("a[{0}, {1}]: {2}", i, j, a[i, j]);
                }
            }
        }
        public static void InputArray(int[,] a)
        {
            int even = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = even;
                    even += 2;
                }
            }
        }
        public static void Print3D(int[,,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(2); k++)
                    {
                        Console.WriteLine("a[{0}, {1}, {2}]: {3}", i, j, k, a[i, j, k]);
                    }
                }
            }
        }
        public static void Input3D(int[,,] a)
        {
            int even = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    for (int k = 0; k < a.GetLength(2); k++)
                    {
                        a[i, j, k] = even;
                        even += 2;
                    }
                }
            }
        }
        public static void Main(string[] args)
        {
            int[,] arr = new int[5, 4];
            InputArray(arr);
            PrintArray(arr);

            int[,,] arr2 = new int[5, 4, 3];
            Input3D(arr2);
            Print3D(arr2);
        }
    }
}