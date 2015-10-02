using System;
using System.IO;
using System.Linq;

namespace _07.Directory_Traversal
{
	class DirectoryTraversal
	{
		static readonly string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

		const string reportFilename = "CSharp Streams and Files Homework Dir Report.txt";
		static readonly string ReportPath = $"{desktopPath}\\{reportFilename}";

		static void Main()
		{
			const string startPath = @"..\..\";

			if (File.Exists(ReportPath))
				File.Delete(ReportPath); // making sure we don't just append to the same file if the program is run more than once

			GenerateReport(startPath, true);

			Console.WriteLine($"Done! Opening {ReportPath}.");

			System.Diagnostics.Process.Start(ReportPath);
		}

		static void GenerateReport(string dir, bool recursive)
		{
			var filePaths = Directory.GetFiles(dir);

			var files = filePaths.Select(path => new FileInfo(path)).ToList();

			var sorted = files
				.OrderBy(file => file.Length)
				.GroupBy(file => file.Extension)
				.OrderByDescending(group => @group.Count())
				.ThenBy(group => @group.Key);

			using (var writer = new StreamWriter(ReportPath, true))
			{
				if (Directory.GetFiles(dir).Count() != 0) // if the directory has no files to report, there's no use outputting anything
				{
					writer.WriteLine($"Current Dir: {dir}");

					foreach (var group in sorted)
					{
						writer.WriteLine(@group.Key);

						foreach (var y in @group)
						{
							writer.WriteLine("--{0} - {1:F3}kb", y.Name, y.Length / 1024.0);
						}
					}
					writer.WriteLine();
				}
			}

			if (recursive)
			{
				var subDirs = Directory.GetDirectories(dir);
				foreach (var subDir in subDirs)
				{
					GenerateReport(subDir, true);
				}
			}
		}
	}
}