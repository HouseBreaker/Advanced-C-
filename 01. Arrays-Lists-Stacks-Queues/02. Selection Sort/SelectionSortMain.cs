using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Selection_Sort
{
	class SelectionSortMain
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			int[] numbers = input.Split()
				.Select(int.Parse)
				.ToArray();

			Console.WriteLine("Original array: {0}", string.Join(" ", numbers));
			Console.WriteLine("Sorted array:   {0}", string.Join(" ", SelectionSort(numbers)));
		}

		static int[] SelectionSort(int[] numbers)
		{
			List<int> sorted = new List<int>(), unsorted = new List<int>(numbers);

			for (int i = 0; i < numbers.Length; i++)
			{
				int min = unsorted[0];

				for (int j = 0; j < unsorted.Count; j++)
				{
					if (unsorted[j] < min)
					{
						min = unsorted[j];
					}
				}

				sorted.Add(min);
				unsorted.Remove(min);
			}
			return sorted.ToArray();
		}
	}
}
