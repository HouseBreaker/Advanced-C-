using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Categorize_Numbers_and_Find_Min_Max_Average
{
	class CategorizeMain
	{
		static void Main()
		{
			string input = Console.ReadLine();
			List<float> numbers = input.Split()
				.Select(float.Parse)
				.ToList();

			List<float> nonRoundList = new List<float>();

			for (int i = 0; i < numbers.Count; i++)
			{
				if (numbers[i] != Math.Round(numbers[i]))
				{
					nonRoundList.Add(numbers[i]);
					numbers.Remove(numbers[i]);
				}
            }
			
			List<float> roundList = new List<float>(numbers);

			Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
				string.Join(", ", roundList),
				roundList.Min(),
				roundList.Max(),
				roundList.Sum(),
				roundList.Average()
				);

			Console.WriteLine();
			Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
				string.Join(", ", nonRoundList),
				nonRoundList.Min(),
				nonRoundList.Max(),
				nonRoundList.Sum(),
				nonRoundList.Average()
				);
		}
	}
}
