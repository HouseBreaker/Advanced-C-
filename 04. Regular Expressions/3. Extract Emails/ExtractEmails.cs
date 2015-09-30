using System;
using System.Text.RegularExpressions;
class Program
{
	static void Main()
	{
		string input = System.IO.File.ReadAllText(@"..\..\teststrings.txt");
		Regex myRegex = new Regex(@"(?<user>[a-z0-9.-_]+)@(?<host>\w+.\w+\.\w+)");

		MatchCollection myCollection = myRegex.Matches(input);
		foreach (Match match in myCollection)
		{
			Console.WriteLine(match);
		}
	}
}