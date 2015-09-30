using System;
using System.Linq;

namespace _04.Text_Filter
{
	class TextFilter
	{
		static void Main()
		{
			string[] bannedWords = Console.ReadLine().Split(new[] {", "}, StringSplitOptions.None).ToArray();
			string input = Console.ReadLine();

			foreach (var word in bannedWords)
			{
				input = input.Replace(word, new string('*', word.Length));
			}

			Console.WriteLine(input);
		}
	}
}
