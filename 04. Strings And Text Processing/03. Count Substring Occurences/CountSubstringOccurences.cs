using System;
using System.Linq;

namespace _03.Count_Substring_Occurences
{
	class CountSubstringOccurences
	{
		static void Main()
		{
			string input = Console.ReadLine();
			string substring = Console.ReadLine();

			int count = 0;
			for (int i = 0; i < input.Length-substring.Length+1; i++)
			{
				if (input.Substring(i, substring.Length).Equals(substring, StringComparison.OrdinalIgnoreCase))
					count++;
			}
			Console.WriteLine(count);

		}
	}
}