using System;
using System.IO;

namespace _01.Odd_Lines
{
	class OddLines
	{
		static void Main()
		{
			using (var reader = new StreamReader(@"..\..\linecount.txt"))
			{
					int lineNumber = 0;
					string line = reader.ReadLine();

					while (line != null)
					{
						lineNumber++;
						bool isOddNumber = (lineNumber + 1)%2 == 0;

						if (isOddNumber) // if odd
							Console.WriteLine(line);

						line = reader.ReadLine();
				}
			}
		}
	}
}
