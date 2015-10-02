using System;
using System.Text.RegularExpressions;

class Exercise
{
	static void Main()
	{
		string email = Console.ReadLine();
		string text = System.IO.File.ReadAllText(@"..\..\text.txt");

		string[] emailBits = email.Split('@');
		string myRegex = string.Format("{0}@{1}", emailBits[0], emailBits[1]);

		string censoredText = Regex.Replace(text, myRegex, new string('*', emailBits[0].Length) + '@' + emailBits[1]);

		Console.WriteLine(censoredText);
	}
}
