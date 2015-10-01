using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Word_Count
{
	class WordCount
	{
		static void Main()
		{
			var wordsFile = @"..\..\words.txt";
			var textFile = @"..\..\text.txt";
			var outputFile = @"..\..\result.txt";

			string[] words;
			string text;

			using (var wordsReader = new StreamReader(wordsFile))
				words = wordsReader.ReadToEnd().Split(new[] {Environment.NewLine}, StringSplitOptions.None);

			using (var textReader = new StreamReader(textFile))
				text = textReader.ReadToEnd();

			Dictionary<string, int> results = new Dictionary<string, int>();
			foreach (var word in words)
			{
				Regex match = new Regex(@"\b" + word + @"\b", RegexOptions.IgnoreCase);
				MatchCollection occurences = match.Matches(text);
				results.Add(word, occurences.Count);
			}
			var sorted = results.OrderByDescending(a => a.Value);

			using (var writer = new StreamWriter(outputFile))
				writer.Write(string.Join(Environment.NewLine, sorted.Select(o => string.Format($"{o.Key} - {o.Value}"))));

			Console.WriteLine($"Done! Wrote results to {Path.GetFullPath(outputFile)}.");
			Console.WriteLine("Press any key to open file.");
			Console.ReadKey();
			Process.Start(outputFile);
		}
	}
}