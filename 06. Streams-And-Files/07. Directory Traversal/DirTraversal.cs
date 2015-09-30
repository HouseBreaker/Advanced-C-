using System;
using System.IO;
using System.Linq;

namespace _07.Directory_Traversal
{
	class DirTraversal
	{
		const string Path = @"..\..\";

        static void Main()
        {
	        Traverse(Path, 0);
		}

		static void Traverse(string path, int tab)
		{
			var tabs = new string('|', tab*2);
			
			Console.WriteLine($"{tabs}{path}");
			var files = Directory.GetFiles(path);
			var dirs = Directory.GetDirectories(path);

			if (dirs.Length == 0 && files.Length == 0)
			{
				//Console.WriteLine("empty dir, going back!");
				Console.WriteLine();
				tab--;
				return;
			}

			if (files.Length > 0)
			{
				Console.WriteLine(tabs + string.Join($"\n{tabs}", files));
				Console.WriteLine();
			}
			
			var subdirs = Directory.GetDirectories(path);

			//foreach (var subdir in subdirs)
			//{
			//	Traverse(subdir, tab+1);
			//}
		}
	}
}
