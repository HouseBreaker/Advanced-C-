using System;
using System.IO;

namespace _04.Copy_Binary_File
{
	class CopyBinaryFile
	{
		const string DuckImagePath = "../../duck.jpg";
		const string DestinationPath = "../../result.jpg";

		static void Main()
		{
			using (var source = new FileStream(DuckImagePath, FileMode.Open))
			{
				using (var destination = new FileStream(DestinationPath, FileMode.Create))
				{
					var fileLength = source.Length;
					var buffer = new byte[4096];

					while (true)
					{
						int readBytes = source.Read(buffer, 0, buffer.Length);
						if (readBytes == 0)
						{
							break;
						}

						destination.Write(buffer, 0, readBytes);

						Console.Clear();
						Console.WriteLine("{0:P}", (double)source.Position / fileLength);
					}
					Console.WriteLine("Done! File written to " + Path.GetFullPath(DestinationPath));
				}
			}
		}
	}
}