using System;
using System.Linq;
using System.Text.RegularExpressions;

class ValidUsers
{
	static void Main()
	{
		string input = Console.ReadLine();

		Regex checkValid = new Regex(@"\b[a-zA-Z]\w{2,24}\b");

		MatchCollection matches = checkValid.Matches(input);

		int first = 0;
		int second = 1;

		int bestSum = 0;
		int sum = 0;
		for (int i = 0; i < matches.Count - 1; i++)
		{
			sum = matches[i].Length + matches[i + 1].Length;
			if (sum > bestSum)
			{
				bestSum = sum;
				first = i;
				second = i + 1;
			}
		}
		Console.WriteLine(matches[first]);
		Console.WriteLine(matches[second]);

	}
}
