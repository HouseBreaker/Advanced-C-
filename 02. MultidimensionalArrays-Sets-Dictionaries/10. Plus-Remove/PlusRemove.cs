using System;
using System.Collections.Generic;
using System.Text;

namespace _10.Plus_Remove
{
	class PlusRemove
	{
		static List<int[]> coordinates = new List<int[]>();
		static List<StringBuilder> matrix = new List<StringBuilder>();
		static char dummy = 'з';

		static void Main()
		{
			//string input = Console.ReadLine();

			////populate
			while (true)
			{
				string input = Console.ReadLine();
				if (input == "END")
					break;

				matrix.Add(new StringBuilder(input));
			}

			for (int row = 0; row < matrix.Count-1; row++)
			{
				for (int col = 0; col < matrix[row].Length; col++)
				{
					FindPlus(row, col);
				}
			}

			foreach (var c in coordinates)
			{
				int x = c[0], y = c[1];
				matrix[x][y] = dummy;
				matrix[x + 1][y] = dummy;
				matrix[x + 1][y - 1] = dummy;
				matrix[x + 1][y + 1] = dummy;
				matrix[x + 2][y] = dummy;
			}

			foreach (var line in matrix)
			{
				line.Replace(dummy.ToString(), "");
				Console.WriteLine(line);
			}
		}

		static void FindPlus(int x, int y)
		{
			StringBuilder validSb = new StringBuilder(matrix[x][y].ToString());

			if (validSb[0] >= 65 && validSb[0] <= 90) //capital letter
			{
				validSb.Append((char)(matrix[x][y] + 32));
			}
			else if (matrix[x][y] >= 97 && matrix[x][y] <= 122) //small letter
			{
				validSb.Append((char)(matrix[x][y] - 32));
			}

			string valid = validSb.ToString();

			try
			{
				if (!valid.Contains(matrix[x + 1][y].ToString()))		//middle
					return;
				if (!valid.Contains(matrix[x + 1][y - 1].ToString()))	//left
					return;
				if (!valid.Contains(matrix[x + 1][y + 1].ToString()))	//right
					return;
				if (!valid.Contains(matrix[x + 2][y].ToString()))		//down
					return;
			}
			catch (IndexOutOfRangeException)
			{
				return;
			}
			catch (ArgumentOutOfRangeException)
			{
				return;
			}

			coordinates.Add(new[] {x, y});
		}
	}
}