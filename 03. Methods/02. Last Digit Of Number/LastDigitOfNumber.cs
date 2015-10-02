using System;

namespace _02.Last_Digit_Of_Number
{
	class LastDigitOfNumber
	{
		static void Main()
		{
			Console.WriteLine(GetLastDigitAsWord(512));
		}

		static string GetLastDigitAsWord(int i)
		{
			switch (i % 10)
			{
				case 0: return "zero";
				case 1: return "one";
				case 2: return "two";
				case 3: return "three";
				case 4: return "four";
				case 5: return "five";
				case 6: return "six";
				case 7: return "seven";
				case 8: return "eight";
				case 9: return "nine";
				default: throw new ArgumentException("Last digit is outside the arabic number system somehow?");
			}
		}
	}
}
