using System;
// Jagged Array is a multidimensional array with varying sizes of inner arrays
namespace JaggedArray
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// 2D Array with unknown column length
			int[][] array1 = new int[3][];
			array1[0] = new int[] { 1, 2, 3, 4, 5 };
			array1[1] = new int[] { 1, 2, 3, 4 };
			array1[2] = new int[] { 1, 2, 3 };

			for (int i = 0; i < array1.GetLength(0); i++)
			{
				for (int j = 0; j < array1[i].Length; j++)
				{
					Console.Write(array1[i][j] + "\t");
				}
				Console.WriteLine();
			}
		}
	}
}