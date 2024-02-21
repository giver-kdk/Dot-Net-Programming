using System;

namespace ArrayStructure
{
    public class Program
    {
        public static void PrintArray(int[] a) 
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("a[{0}]: {1}", i, a[i]);
            }
        }
        public static void InputArray(int[] a)
        {
            int even = 0;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = even;
                even += 2;
            }
        }
        public static void Main(string[] args)
        {
            int[] arr = new int[30];
            InputArray(arr);
            PrintArray(arr);
        }
    }
}