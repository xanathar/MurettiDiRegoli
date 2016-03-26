using System;
using System.Linq;

namespace Regoli
{
	class Program
	{
		const int LIMIT = 5;

		static int g_Found = 0;

		static void Main(string[] args)
		{
			for (int i = 1; i <= LIMIT; i++)
			{
				GenerateCombinations(i);
			}

			Console.WriteLine("----------------------------");
			Console.WriteLine("Combinazioni : {0}", g_Found);

			Console.ReadKey();
		}

		private static void GenerateCombinations(int num)
		{
			int[] digits = new int[num];
			IterateCombinations(0, digits);
		}

		private static void IterateCombinations(int place, int[] digits)
		{
			if (place == digits.Length)
			{
				if (digits.Sum() == LIMIT)
					Found(digits);
			}
			else
			{
				int max = LIMIT + 1 - digits.Length;

				for (int i = 1; i <= max; i++)
				{
					digits[place] = i;
					IterateCombinations(place + 1, digits);
				}
			}
		}

		private static void Found(int[] digits)
		{
			string str = string.Join("+", digits);
			Console.WriteLine(str);
			g_Found += 1;
		}
	}
}
