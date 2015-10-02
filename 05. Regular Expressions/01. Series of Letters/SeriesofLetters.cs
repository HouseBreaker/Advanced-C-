using System;
using System.Text.RegularExpressions;

class SeriesofLetters
{
	static void Main()
	{
		string input = "aaaaabbbbbcdddeeeedssaa";

		Regex myRegex = new Regex(@"([a-z])\1*");
		MatchCollection matches = myRegex.Matches(input);

		foreach (Match match in matches)
		{
			Console.Write(match.Value[0]);
		}
		Console.WriteLine();

	}
}
