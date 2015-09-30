using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Longest_Increasing_Sequence
{
	class LongestSequenceMain
	{
		static void Main()
		{
			string input = Console.ReadLine();

			int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

			//TODO: split into subarrays
			List<List<int>> subArrays = new List<List<int>>();
			List<int> subArray = new List<int>();

			//find sequences - hacky algorithm but it works
			for (int i = 1; i < numbers.Length; i++)
			{
				if (numbers[i] > numbers[i - 1])
				{
					subArray.Add(numbers[i - 1]);
				}
				else
				{
					subArray.Add(numbers[i - 1]);
					subArrays.Add(new List<int>(subArray));
					subArray.Clear();
				}

				if (i == numbers.Length - 1)
				{
					subArray.Add(numbers[i]);
					subArrays.Add(new List<int>(subArray));
					subArray.Clear();
				}
			}

			//print subarrays
			foreach (List<int> list in subArrays)
			{
				Console.WriteLine(string.Join(" ", list));
			}

			//find longest one, if multiple, print leftmost

			List<int> longestSequence = new List<int>();
			for (int i = subArrays.Count - 1; i > 0; i--)
			{
				if (subArrays[i-1].Count >= subArrays[i].Count)
				{
					longestSequence = subArrays[i-1];
				}
			}

			if (subArrays.Count == 1)
			{
				longestSequence = subArrays[0];
			}

			Console.WriteLine("Longest: {0}", string.Join(" ", longestSequence));
		}
	}
}
