using System;

namespace Array2D
{
	public class Program
	{
		const int ROW = 2;
		const int COL = 3;
		static void Main(string[] args)
		{
			// Here, 'int[,]' means it is a 2D array where comma separtes the dimension
			int[,] marks = new int[ROW, COL];

			// 2D Array Declaration and Definition
			int[,] graph = {
				{1, 2, 3},
				{4, 5, 6}
			};
			
			// Serially accessing all elements of 2D array using 'foreach'  
			foreach(int elem in graph)
			{
				Console.Write("{0}\t", elem);
			}
			Console.WriteLine();
			Console.WriteLine();

			// 2D Array Traversal like in C Program
			for(int i = 0; i < ROW; i++)
			{
				for(int j = 0; j < COL; j++)
				{
					// Accessing array element different than other language
					Console.Write("{0}\t",graph[i, j]);
				}
				Console.WriteLine();
			}
			Console.WriteLine();

			// 2D Array Traversal using 'GetLength()' method
			// 'GetLength()' is used to extart length of particular dimension starting with 0
			// Syntax: 'array.GetLength(dimension)'
			for(int i = 0; i < graph.GetLength(0); i++)
			{
				for(int j = 0; j < graph.GetLength(1); j++)
				{
					Console.Write("{0}\t",graph[i, j]);
				}
				Console.WriteLine();
			}
		}
	}
}