using System;
using System.Linq;

namespace _02.Maximal_Sum
{
	class MaximalSum
	{
		static int[,] matrix;

		static void Main()
		{
			//get number of rows & cols
			int[] rowsCols = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
			int rows = rowsCols[0], cols = rowsCols[1];

			matrix = new int[rows, cols];

			//populate matrix
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				int[] current = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

				for (int j = 0; j < current.Length; j++)
				{
					matrix[i, j] = current[j];
				}
			}

			int validRows = matrix.GetLength(0) - 2;
			int validCols = matrix.GetLength(1) - 2;
			int biggestSum = 0, biggestSumRow = 0, biggestsumCol = 0;
			for (int i = 0; i < validCols; i++)
			{
				for (int j = 0; j < validRows; j++)
				{
					if (biggestSum < SumGrid(i, j))
					{
						biggestSum = SumGrid(i, j);
						biggestsumCol = i;
						biggestSumRow = j;
					}
				}
			}

			Console.WriteLine($"Sum = {biggestSum}");

			PrintGrid(biggestsumCol, biggestSumRow);

			//Console.WriteLine();
		}

		private static int SumGrid(int startingRow, int startingCol)
		{
			int sum = 0;
			for (int i = startingCol; i < startingCol + 3; i++)
			{
				for (int j = startingRow; j < startingRow + 3; j++)
				{
					sum += matrix[i, j];
				}
			}
			return sum;
		}

		private static void PrintGrid(int startingRow, int startingCol)
		{
			for (int i = startingCol; i < startingCol + 3; i++)
			{
				//Console.Write("|");
				for (int j = startingRow; j < startingRow + 3; j++)
				{
					Console.Write(matrix[i, j] + " "); //+ "|");
				}
				Console.WriteLine();
			}
		}
	}
}