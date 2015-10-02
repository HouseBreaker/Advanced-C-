using System;
using System.Text;
using System.Text.RegularExpressions;

class Chains
{
	static void Main()
	{
		//string input = System.IO.File.ReadAllText(@"..\..\themanual.txt");

		string input = Console.ReadLine();
		string getp = @"<p>(.*?)<\/p>";
		MatchCollection ptags = new Regex(getp).Matches(input);
		
		StringBuilder sb = new StringBuilder();
		
		foreach (Match match in ptags)
		{
			sb.Append(match.Groups[1]);
		}
		
		//get rid of non-(a-z, A-Z, 0-9 stuff
		string invalidcharsRegex = @"[^a-z0-9]";
		for (int i = 0; i < sb.Length; i++)
		{
			if (Regex.IsMatch(sb[i].ToString(), invalidcharsRegex))
			{
				sb[i] = ' ';
			}
		}


		sb = new StringBuilder(Regex.Replace(sb.ToString(), @"( )\1*", " "));
		
		//ROT13
		for (int i = 0; i < sb.Length; i++)
		{
			if (Regex.IsMatch(sb[i].ToString(), @"[a-m]"))
			{
				sb[i] = (char)(sb[i] + 13);
			}
			else if (Regex.IsMatch(sb[i].ToString(), @"[n-z]"))
			{
				sb[i] = (char)(sb[i] - 13);
			}
		}

		Console.WriteLine(sb);
	}
}