using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace _06.Zipping_Sliced_Files
{
	class ZippingSlicedFile
	{
		const string InputFile = @"..\..\input.txt";
		const string OutputFolder = @"..\..\_SplitFilesOutput\";

		const int Parts = 5;
		static List<string> files;

		static void Main()
		{
			SplitFiles(Parts, InputFile, OutputFolder);
			AssembleFiles();
		}

		static void AssembleFiles()
		{
			var outputFile = $"{OutputFolder}{Path.GetFileName(InputFile)}";

			if (File.Exists(outputFile))
				File.Delete(outputFile);


			using (var destination = new FileStream(outputFile, FileMode.Append))
			{
				foreach (string file in files)
				{
					using (var source = new FileStream(file, FileMode.Open))
					{
						var buffer = new byte[4096];

						while (true)
						{
							using (var gzipStream = new GZipStream(source, CompressionMode.Decompress, false))
							{
								int readBytes = gzipStream.Read(buffer, 0, buffer.Length);

								if (readBytes == 0)
								{
									break;
								}

								destination.Write(buffer, 0, readBytes);
							}
						}
					}
				}
			}
		}

		static void SplitFiles(int parts, string inputFile, string outputFolder)
		{
			using (var inputStream = new FileStream(inputFile, FileMode.Open))
			{
				files = new List<string>();

				for (int part = 1; part <= parts; part++)
				{
					string outputFileName = Path.GetFileNameWithoutExtension(inputFile) + "-Part" + part + Path.GetExtension(inputFile) + ".gz";
					string outputFilePath = outputFolder + outputFileName;

					files.Add(outputFilePath);
					var partSize = (int)Math.Ceiling((double)inputStream.Length / parts);

					using (var outputStream = new FileStream(outputFilePath, FileMode.Create))
					{
						var buffer = new byte[partSize];

						int readBytes = inputStream.Read(buffer, 0, partSize);

						using (var zipStream = new GZipStream(outputStream, CompressionMode.Compress, false))
							zipStream.Write(buffer, 0, readBytes);
						//outputStream.Write(buffer, 0, readBytes);
					}


				}
			}

			Console.WriteLine("Done! Files written at " + Path.GetFullPath(outputFolder));
		}
	}
}
