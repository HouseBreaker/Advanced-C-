using System;
using System.Linq;

namespace _04.SequenceInMatrix
{
	class SequenceInMatrix
	{
		static void Main()
		{
			string[,] matrix =
			{
				{"s", "qq", "s" },
				{"pp", "pp", "s"},
				{"pp", "qq", "s"},
			};

			PrintMatrix(matrix);
			Console.WriteLine();
			LongestSeq(matrix);

		}

		private static void LongestSeq(string[,] matrix)
		{
			int biggestSequence = 1;
			string biggestValue = "";
			int count = 1;

			//check horizontally
			for (int row = 0; row < matrix.GetLength(0); row++)
			{

				for (int col = 0; col < matrix.GetLength(1) - 1; col++)
				{
					count = (matrix[row, col] == matrix[row, col + 1]) ? count + 1 : 1;

					if (count > biggestSequence)
					{
						biggestSequence = count;
						biggestValue = matrix[row, col];
					}
				}
			}
			count = 1;

			//check vertically
			for (int col = 0; col < matrix.GetLength(1); col++)
			{
				for (int row = 0; row < matrix.GetLength(0) - 1; row++)
				{
					count = (matrix[row, col] == matrix[row + 1, col]) ? count + 1 : 1;

					if (count > biggestSequence)
					{
						biggestSequence = count;
						biggestValue = matrix[row, col];
					}
				}
			}
			count = 1;

			//check diagonally left to right
			for (int row = 0, col = 0; row < matrix.GetLength(0) - 1 && col < matrix.GetLength(1) - 1; row++, col++)
			{
				count = (matrix[row, col] == matrix[row + 1, col + 1]) ? count + 1 : 1;

				if (count > biggestSequence)
				{
					biggestSequence = count;
					biggestValue = matrix[row, col];
				}
			}
			count = 1;

			//check diagonally right to left
			for (int row = 0, col = matrix.GetLength(1)-1; row < matrix.GetLength(0)-1 && col > 0; row++, col--)
			{
				count = (matrix[row, col] == matrix[row + 1, col - 1]) ? count + 1 : 1;
                if (count > biggestSequence)
				{
					biggestSequence = count;
					biggestValue = matrix[row, col];
				}
			}

			Console.WriteLine(string.Join(", ", Enumerable.Repeat(biggestValue, biggestSequence)));
		}

		static void PrintMatrix(string[,] matrix)
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write("{0}", matrix[i,j].PadRight(3));
				}
				Console.WriteLine();
			}
		}
	}
}