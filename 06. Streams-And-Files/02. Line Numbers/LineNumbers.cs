using System;
using System.Diagnostics;
using System.IO;

namespace _02.Line_Numbers
{
	class LineNumbers
	{
		static void Main()
		{
			string inputFile = @"..\..\file.txt";
			string outputFile = @"..\..\outputfile.txt";

			using (StreamReader reader = new StreamReader(inputFile))
			{
				using (StreamWriter writer = new StreamWriter(outputFile))
				{
					string[] lines = reader.ReadToEnd().Split('\n');
					
					for (int line = 0; line < lines.Length; line++)
					{
						writer.Write("Line {0} - {1}", line+1, lines[line]);
					}
					Console.WriteLine($"Wrote {lines.Length} lines to {Path.GetFullPath(outputFile)}");

					Console.WriteLine("Press any key to open file.");
					Console.ReadKey();
					Process.Start(outputFile);
				}
			}
		}
	}
}
