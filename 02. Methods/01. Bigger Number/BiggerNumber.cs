using System;

namespace _01.Bigger_Number
{
	class BiggerNumber
	{
		static void Main()
		{
			int n1 = int.Parse(Console.ReadLine());
			int n2 = int.Parse(Console.ReadLine());

			Console.WriteLine(GetMax(n1, n2));
		}

		static int GetMax(int n1, int n2)
		{
			int max = n1 > n2 ? n1 : n2;
			return max;
		}
	}
}
