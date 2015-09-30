using System;
using System.Linq;

namespace _01.Reverse_String
{
	class ReverseString
	{
		static void Main()
		{
			string input = Console.ReadLine();
			Console.WriteLine(input.Reverse().ToArray());
		}
	}
}
