using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Count_Symbols
{
	class CountSymbols
	{
		static void Main()
		{
			// using LINQ is essentially cheating here... 

			string input = Console.ReadLine();

			char[] splitString = input.ToCharArray().Distinct().ToArray();	//char array of input without repetition
			Array.Sort(splitString); //C# does lexicographical sort by default

			//make a dictionary where we'll store the chars + occurences
			Dictionary<char, int> charsPlusOccurences = new Dictionary<char, int>(); 
			
			//count occurences & plug them into the dictionary
			Array.ForEach(splitString, symbol => { charsPlusOccurences[symbol] = input.ToCharArray().Count(f => f == symbol); }); 

			foreach (var symbol in charsPlusOccurences)
			{
				Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s)");
			}
		}
	}
}
