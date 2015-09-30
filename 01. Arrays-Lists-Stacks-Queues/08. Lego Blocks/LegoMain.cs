using System;
using System.Linq;

namespace _08.Lego_Blocks
{
	class LegoMain
	{
		static void Main()
		{
			var rows = int.Parse(Console.ReadLine());
			int[][] arrayOne = new int[rows][];
			int[][] arrayTwo = new int[rows][];
			int[][] arrayThree = new int[rows][];

			//input first array
			for (var i = 0; i < rows; i++)
			{
				string arrayOneString = Console.ReadLine().Trim(' ');
				arrayOne[i] = arrayOneString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.ToArray();
			}

			//input second array (reversed)
			for (var i = 0; i < rows; i++)
			{
				string arrayTwoString = Console.ReadLine().Trim(' ');
				arrayTwo[i] = arrayTwoString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(int.Parse)
					.Reverse()
					.ToArray();
			}

			//combine 'em
			for (var i = 0; i < rows; i++)
			{
				arrayThree[i] = new int[arrayOne[i].Length + arrayTwo[i].Length];

				Array.Copy(arrayOne[i], arrayThree[i], arrayOne[i].Length);
				Array.Copy(arrayTwo[i], 0, arrayThree[i], arrayOne[i].Length, arrayTwo[i].Length);
			}

			bool rectangle = true;
			for (var i = 1; i < rows; i++)
			{
				if (arrayThree[i].Length != arrayThree[i - 1].Length)
				{
					rectangle = false;
					break;
				}
			}

			if (rectangle)
			{
				for (var i = 0; i < rows; i++)
				{
					string result = string.Format("[" + string.Join(", ", arrayThree[i]) + "]");
					Console.WriteLine(result);
				}
			}
			else
			{
				var total = 0;

				for (var i = 0; i < arrayThree.Length; i++)
				{
					total += arrayThree[i].Length;
				}
				Console.WriteLine("The total number of cells is: " + total);
			}
		}
	}
}