using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _09.Terrorists_Win_
{
	class TerroristsWin
	{
		static void Main()
		{
			string input = Console.ReadLine();
			Regex bombDetector = new Regex(@"\|([^|]*)\|");

			StringBuilder destroyed = new StringBuilder(input);

			MatchCollection bombs = bombDetector.Matches(input);
			foreach (Match bomb in bombs)
			{
				int power = 0;
				int startIndex = input.IndexOf(bomb.Value);

				if (bomb.Value.Length != 0)
				{
					//calculate bomb power (last digit of sum of ascii values)
					power = (bomb.Groups[1].Value.ToCharArray().Sum(c => c) % 10);
				}

				for (int i = startIndex-power; i < startIndex+bomb.Value.Length+power; i++)
				{
					try
					{
						destroyed[i] = '.';
					}
					catch (ArgumentOutOfRangeException)
					{
						//do nothing because we would be out of range here
					}
				}
			}

			Console.WriteLine(destroyed);

			//ако някой може да ми каже защо изкарва само 87/100 в Judge, много ще съм му благодарен
		}
	}
}