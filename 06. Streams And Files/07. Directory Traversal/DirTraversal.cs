using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

internal class DirectoryTraversal
{
	static void Main()
	{
		string[] filePaths = Directory.GetFiles(@"../../");

		List<FileInfo> files = filePaths.Select(path => new FileInfo(path)).ToList();

		var sorted = files
			.OrderBy(file => file.Length)
			.GroupBy(file => file.Extension)
			.OrderByDescending(group => group.Count())
			.ThenBy(group => group.Key);

		string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

		using (var writer = new StreamWriter(desktopPath + "/report.txt"))
		{
			foreach (var group in sorted)
			{
				writer.WriteLine(group.Key);

				foreach (var y in group)
				{
					writer.WriteLine("--{0} - {1:F3}kb", y.Name, y.Length / 1024.0);
				}
			}
		}

		System.Diagnostics.Process.Start(desktopPath + "/report.txt");
	}
}