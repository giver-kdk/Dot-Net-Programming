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
        public static void Main(string[] args)
        {
            int[,] arr = new int[5, 4];
            InputArray(arr);
            PrintArray(arr);
        }
    }
}