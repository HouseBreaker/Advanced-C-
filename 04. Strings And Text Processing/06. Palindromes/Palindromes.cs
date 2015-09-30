using System;
using System.Linq;

namespace _06.Palindromes
{
	class Palindromes
	{
		static void Main()
		{
			string[] input = Console.ReadLine().Split(' ', ',', '.', '?', '!').Distinct().ToArray();
			Array.Sort(input);

			Console.WriteLine(string.Join(", ", input.Where(IsPalindrome)));
		}

		static bool IsPalindrome(string s)
		{
			return s == new string(s.Reverse().ToArray()) && s != string.Empty;
		}
	}
}
