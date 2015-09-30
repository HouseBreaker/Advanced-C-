using System;

namespace _06.Collect_The_Coins
{
	class CollectCoins
	{
		static readonly char[][] matrix = new char[4][];
		static int hits, coins;
	
		static void Main()
		{
			//populate the matrix
			for (int i = 0; i < 4; i++)
			{
				matrix[i] = (Console.ReadLine().ToCharArray());
			}

			//get the commands
			string input = Console.ReadLine();
			int col = 0, row = 0;

			foreach (char t in input)
			{
				switch (t)
				{
					case '^':
						if (commandIsCorrect(row-1, col))
							row--;
						break;

					case 'V':
						if (commandIsCorrect(row + 1, col))
							row++;
						break;

					case '<':
						if (commandIsCorrect(row, col-1))
							col--;
						break;

					case '>':
						if (commandIsCorrect(row, col + 1))
							col++;
						break;
				}
			}

			Console.WriteLine("Coins collected: {0}", coins);
			Console.WriteLine("Walls hit: {0}", hits);
		}

		static bool commandIsCorrect(int row, int col)
		{
			try
			{
				if (matrix[row][col] == '$')
				{
					coins++;
				}
			}
			catch (IndexOutOfRangeException)
			{
				hits++;
				return false;
			}
			return true;
		}
	}
}