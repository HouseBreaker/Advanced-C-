using System;

namespace _06.Number_Calculations
{
	class NumberCalculations
	{
		static void Main()
		{
			decimal[] numbers = { 1, 2, 3, 4, 5 };
			double[] numbers2 = { 1.2, 2.4, 3.1, 4.8, 5.2 };

			Console.WriteLine($"Set of numbers: {string.Join(", ", numbers)}");
			Console.WriteLine("Min: {0}, Max: {1}, Average: {2}, Sum: {3}, Product: {4}", 
				Min(numbers), Max(numbers), Average(numbers), Sum(numbers), Product(numbers));

			Console.WriteLine();
			Console.WriteLine($"Set of double numbers: {string.Join(", ", numbers2)}");
			Console.WriteLine("Min: {0:F2}, Max: {1:F2}, Average: {2:F2}, Sum: {3:F2}, Product: {4:F2}",
				Min(numbers2), Max(numbers2), Average(numbers2), Sum(numbers2), Product(numbers2));
		}

		static decimal Min(decimal[] numbers)
		{
			decimal min = decimal.MaxValue;
			for (int i = 0; i < numbers.Length; i++)
			{
				min = (numbers[i] < min) ? numbers[i] : min;
			}
			return min;
		}

		static double Min(double[] numbers)
		{
			double min = double.MaxValue;
			for (int i = 0; i < numbers.Length; i++)
			{
				min = (numbers[i] < min) ? numbers[i] : min;
			}
			return min;
		}

		static decimal Max(decimal[] numbers)
		{
			decimal max = decimal.MinValue;
			for (int i = 0; i < numbers.Length; i++)
			{
				max = (numbers[i] > max) ? numbers[i] : max;
			}
			return max;
		}

		static double Max(double[] numbers)
		{
			double max = double.MinValue;
			for (int i = 0; i < numbers.Length; i++)
			{
				max = (numbers[i] > max) ? numbers[i] : max;
			}
			return max;
		}

		static decimal Average(decimal[] numbers)
		{
			return Sum(numbers)/numbers.Length;
		}

		static double Average(double[] numbers)
		{
			return Sum(numbers) / numbers.Length;
		}

		static decimal Sum(decimal[] numbers)
		{
			decimal sum = 0;
			foreach (var i in numbers)
			{
				sum += i;
			}
			return sum;
		}

		static double Sum(double[] numbers)
		{
			double sum = 0;
			foreach (var i in numbers)
			{
				sum += i;
			}
			return sum;
		}

		static decimal Product(decimal[] numbers)
		{
			decimal product = 1;
			foreach (var item in numbers)
			{
				product *= item;
			}
			return product;
		}

		static double Product(double[] numbers)
		{
			double product = 1;
			foreach (var item in numbers)
			{
				product *= item;
			}
			return product;
		}
	}
}
