using System;

namespace _02.String_Length
{
	class StringLength
	{
		static void Main()
		{
			string input = Console.ReadLine();
			string manipulated = string.Empty;

			if (input.Length < 20)
			{
				manipulated = string.Concat(input, new string('*', 20 - input.Length));
			}
			else
			{
				manipulated = input.Substring(0, 20);
			}
			Console.WriteLine(manipulated);
		}
	}
}
