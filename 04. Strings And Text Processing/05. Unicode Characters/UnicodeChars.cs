using System;

namespace _05.Unicode_Characters
{
	class UnicodeChars
	{
		static void Main()
		{
			string input = Console.ReadLine();

			foreach (var letter in input)
			{
				Console.Write("\\u{0:X4}", (int)letter);
			}
			Console.WriteLine();
		}
	}
}
