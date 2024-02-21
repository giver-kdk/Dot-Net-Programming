// C# code to print user given string in reverse order and print occurrance of individual charater
using System;
using System.Dynamic;
using System.Linq;

namespace StringWAP
{
    public class Program
    {
        public static int GetIndex(char[] charArray, char ch)
        {
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == ch) return i;
                else continue;
            }
            return -1;
        }
        public static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();

            char[] symbols = new char[str.Length];
            int[] counts = new int[str.Length];
            counts[0] = 0;
            for (int i = 0, j = 0, k = 0; i < str.Length; i++)
            {
                if (symbols.Contains(str[i]))
                {
                    int index = GetIndex(symbols, str[i]);
                    counts[index]++;
                }
                else
                {
                    symbols[j++] = str[i];
                    counts[k++] = 1;
                }
            }
            for (int i = 0; symbols[i] != 0; i++)
            {
                Console.WriteLine(symbols[i] + " has occurred " + counts[i] + " times");
            }
        }
    }
}