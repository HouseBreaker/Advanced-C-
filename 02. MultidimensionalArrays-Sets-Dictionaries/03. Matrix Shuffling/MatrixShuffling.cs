using System;
using System.Linq;

namespace _03.Matrix_Shuffling
{
	class MatrixShuffling
	{
		static string[,] matrix;
		static int rows, cols;

		static void Main()
		{
			//input matrix dimensions
			rows = int.Parse(Console.ReadLine());
			cols = int.Parse(Console.ReadLine());

			matrix = new string[rows, cols];

			PopulateMatrix();

			string input = string.Empty;
			while (input != "END")
			{
				input = Console.ReadLine();
				if (input == "END")
				{
					break;
				}
				InterpretCommand(input);
			}
		}

		static void InterpretCommand(string input)
		{
			try
			{
				//is the beginning "swap"?
				if (input.Substring(0, 5) != "swap ")
				{
					throw new FormatException();
				}

				//are the coordinates invalid?
				int[] coordinates = input.Substring(5).Split(' ').Select(int.Parse).ToArray();
				if (coordinates.Length != 4)
				{
					throw new FormatException();
				}

				//can the swap be done?
				int x1 = coordinates[0], y1 = coordinates[1];
				int x2 = coordinates[2], y2 = coordinates[3];

				string temp = matrix[x1, y1];
				matrix[x1, y1] = matrix[x2, y2];
				matrix[x2, y2] = temp;

				PrintMatrix();
			}
			catch (FormatException)
			{
				Console.WriteLine("Invalid input!");
			}
			catch (ArgumentOutOfRangeException)
			{
				Console.WriteLine("Invalid input!");
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("Invalid input!");
			}
		}

		static void PopulateMatrix()
		{
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					matrix[i, j] = Console.ReadLine();
				}
			}
		}

		static void PrintMatrix()
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(matrix[i, j] + " ");
				}
				Console.WriteLine();
			}
		}
	}
}
