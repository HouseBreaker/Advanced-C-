using System;
using System.Collections.Generic;

namespace _08.Night_Life
{
	class NightLife
	{
		static void Main()
		{
			//city                   //venue //performer
			Dictionary<string, SortedDictionary<string, SortedSet<string>>> clubs = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

			while (true)
			{
				string input = Console.ReadLine();

				if (input != "END")
				{
					string[] command = input
						.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
					string city = command[0];
					string venue = command[1];
					string performer = command[2];
					
					if (!clubs.ContainsKey(city))
					{
						SortedSet<string> performers = new SortedSet<string> {performer};
						SortedDictionary<string, SortedSet<string>> venues = new SortedDictionary<string, SortedSet<string>>
						{
							{venue, performers}
						};

						clubs.Add(city, venues);
					}

					else if (clubs.ContainsKey(city))
					{
						if (!clubs[city].ContainsKey(venue))
						{ 
							SortedSet<string> performers = new SortedSet<string> {performer};
							clubs[city].Add(venue, performers);
						}
						else if (clubs[city].ContainsKey(venue))
						{
							clubs[city][venue].Add(performer);
						}
					}
				}
				else
				{
					break;
				}
			}

			// print it
			foreach (var pair1 in clubs)
			{
				Console.WriteLine(pair1.Key);
				foreach (var pair2 in pair1.Value)
				{
					Console.WriteLine("->{0}: {1}", pair2.Key, string.Join(", ", pair2.Value));
				}
			}
		}
	}
}