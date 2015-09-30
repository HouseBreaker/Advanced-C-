using System;
using System.Collections.Generic;

namespace _07.Phonebook
{
	class Phonebook
	{
		static void Main()
		{
			string input = Console.ReadLine();
			Dictionary<string,string> phonebook = new Dictionary<string, string>();

			while (input != "search")
			{
				phonebook.Add(input.Split('-')[0], input.Split('-')[1]);
				input = Console.ReadLine();
			}

			input = Console.ReadLine();
			while (input != "end") //since there weren't really any further instructions on when to stop after the search command is issued...
			{
				if (phonebook.ContainsKey(input))
				{
					Console.WriteLine($"{input} -> {phonebook[input]}");
				}
				else
				{
					Console.WriteLine($"Contact {input} does not exist.");
				}
				input = Console.ReadLine();
			}

		}
	}
}
