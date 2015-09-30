using System;
using System.Linq;

namespace _05.Reverse_Number
{
	class ReverseNumber
	{
		static void Main()
		{
			string input = Console.ReadLine();
			Console.WriteLine(Reversed(input));
		}

		static double Reversed(string input)
		{
			return double.Parse(new string(input.Reverse().ToArray()));
		}
	}
}
