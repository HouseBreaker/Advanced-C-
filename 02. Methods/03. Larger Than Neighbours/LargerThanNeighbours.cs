using System;

public class LargerThanNeighbours
{
	static void Main()
	{
		int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

		for (int i = 0; i < numbers.Length; i++)
		{
			Console.WriteLine(IsLargerThanNeighbors(numbers, i));
		}
	}

	static public bool IsLargerThanNeighbors(int[] numbers, int n)
	{
		if (n == 0)
		{
			if (numbers[n] > numbers[n + 1])
				return true;
		}
		else if (n == numbers.Length - 1)
		{
			if (numbers[n] > numbers[n - 1])
				return true;
		}
		else
		{
			if (numbers[n] > numbers[n - 1] && numbers[n] > numbers[n + 1])
				return true;
		}
		return false;
	}
}
