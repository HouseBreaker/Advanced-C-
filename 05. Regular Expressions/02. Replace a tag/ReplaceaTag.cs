using System;
using System.Text.RegularExpressions;

	class ReplaceaTag
	{
		static void Main()
		{
			string text = System.IO.File.ReadAllText(@"..\..\html.htm");
			Regex myRegex = new Regex(@"<a (?s)(?<rest>.*?)<\/a>");
			var replaced = myRegex.Replace(text, "[URL ${rest}[/URL]");

			Console.WriteLine(replaced);
		}
	}
