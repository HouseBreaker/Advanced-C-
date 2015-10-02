using System;

class Program
{
	static void Main()
	{
		int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
		int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
		int[] sequenceThree = { 1, 1, 1 };

		Console.WriteLine(IndexOfFirstElementLargerThanNeighbours(sequenceOne));
		Console.WriteLine(IndexOfFirstElementLargerThanNeighbours(sequenceTwo));
		Console.WriteLine(IndexOfFirstElementLargerThanNeighbours(sequenceThree));
	}

	static int IndexOfFirstElementLargerThanNeighbours(int[] seq)
	{
		for (int i = 0; i < seq.Length; i++)
		{
			if (LargerThanNeighbours.IsLargerThanNeighbors(seq, i))
			{
				return i;
			}
		}
		return -1;
	}
}