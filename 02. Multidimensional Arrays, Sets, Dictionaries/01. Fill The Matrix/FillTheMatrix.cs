using System;

namespace _01.Fill_The_Matrix
{
	class FillTheMatrix
	{
		static int n = 4;
		static readonly int[,] matrix = new int[n, n];
		static void Main()
		{
			//method a
			MethodA();
			PrintMatrix();

			Console.WriteLine();

			//method b
			MethodB();
			PrintMatrix();
		}

		private static void MethodA()
		{
			int t = 1;
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[j, i] = t;
					t++;
				}
			}
		}

		static void MethodB()
		{
			int t = 1;
			bool flipPosition = false;

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				if (!flipPosition) //go downward
				{
					for (int j = 0; j < matrix.GetLength(1); j++)
					{
						matrix[j, i] = t;
						t++;
					}
				}
				if (flipPosition) //go downward
				{
					for (int j = matrix.GetLength(1)-1; j >= 0; j--)
					{
						matrix[j, i] = t;
						t++;
					}
				}

				flipPosition = !flipPosition;
			}
		}

		static void PrintMatrix()
		{
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				Console.Write("|");
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write("{0}", matrix[i, j].ToString().PadLeft(2));
					Console.Write("|");
				}
				Console.WriteLine();
			}
		}
	}
}
