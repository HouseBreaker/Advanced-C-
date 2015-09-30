using System;
using System.Linq;

namespace _01.Arrays_Lists_Stacks_Queues_Homework
{
	class BubbleSortMain
	{
		static void Main()
		{
			string input = Console.ReadLine();
			int[] numbers = input.Split()
				.Select(int.Parse)
				.ToArray();

			Console.WriteLine("Original numbers: {0}", string.Join(" ", numbers));
			Console.WriteLine("Sorted numbers:   {0}", string.Join(" ", BubbleSort(numbers)));

			//Another solution using a file which stores the numbers

			//int[] numbers = File.ReadAllLines(@"..\..\random.txt").Select(int.Parse).ToArray();

			//Stopwatch trackerStopwatch = new Stopwatch();
			//trackerStopwatch.Start();

			//File.WriteAllText(@"..\..\sorted.txt", string.Join(Environment.NewLine, BubbleSort(numbers)));
			//trackerStopwatch.Stop();

			//Console.WriteLine("Bubble sort of {0} numbers took {1:F2} seconds to sort",
			//numbers.Length,
			//(double)timeItTook.ElapsedMilliseconds / 1000);
		}

		static int[] BubbleSort(int[] numbers)
		{
			bool hasMoved;

			do
			{
				hasMoved = false;

				for (int i = 1; i < numbers.Length; i++)
				{
					if (numbers[i] < numbers[i - 1])
					{
						hasMoved = true;

						//swap i and i-1 w/o temp
						numbers[i] = numbers[i] + numbers[i - 1];
						numbers[i - 1] = numbers[i] - numbers[i - 1];
						numbers[i] = numbers[i] - numbers[i - 1];
					}
				}

			} while (hasMoved);

			return numbers;
		}
	}
}