using System;
using System.Text.RegularExpressions;

class Program
{
	static void Main()
	{
		string input = Console.ReadLine();
		Regex myRegex = new Regex(@"[A-Z][\w\s,()""1-9]*\b" + input + @"\b[\w\s,()""1-9]*[.?!]");
		string sentence =
			"This is my cat! And this is my dog. We happily live in Paris – the most beautiful city in the world! Isn’t it great? Well it is :)";

		MatchCollection myCollection = myRegex.Matches(sentence);

		foreach (var contain in myCollection)
		{
				Console.WriteLine(contain);
		}
	}
}
