using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Sentences_Of_Equal_Strings
{
	class EqualStringsMain
	{
		static void Main()
		{
			string input = Console.ReadLine();
			Regex getRepeatingRegex = new Regex(@"(((\w+) )\2*\3)|(\w+)");

			var matches = getRepeatingRegex.Matches(input)
				.Cast<Match>()
				.Select(a => a.Value);

			Console.WriteLine(string.Join(Environment.NewLine, matches));
		}
	}
}
