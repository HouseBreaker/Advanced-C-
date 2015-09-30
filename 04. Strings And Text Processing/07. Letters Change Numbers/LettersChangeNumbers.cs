using System;
using System.Linq;

namespace _07.Letters_Change_Numbers
{
	class LettersChangeNumbers
	{
		static void Main()
		{
			string input = Console.ReadLine();

			char splitChar = ' ';
			string[] elements = input.Split(splitChar).Where(a => !string.IsNullOrEmpty(a)).ToArray();
			double total = 0;

			foreach (var item in elements)
			{
				char firstLetter = item[0], lastLetter = item[item.Length-1];
				double thenumber = double.Parse(item.Substring(1, item.Length - 2));

				thenumber = IsCapital(firstLetter) ? thenumber / (firstLetter - 64) : thenumber * (firstLetter - 96);
				thenumber = IsCapital(lastLetter)  ? thenumber - (lastLetter  - 64) : thenumber + (lastLetter  - 96);

				total += thenumber;
			}
			Console.WriteLine("{0:F2}", total);
		}

		static bool IsCapital(char letter)
		{
			if (letter >= 65 && letter <= 90)
				return true;
			return false;
		}
	}
	//this solution gets 70/100 from the Judge system with 3 runtime error results. My original Regex solution gets 100/100
}