using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace sortering
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> lista = new List<int>();

			Random rnd = new Random();

			int antal = 1000;

			for (int i = 0; i < antal; i++)
			{
				lista.Add(rnd.Next(0, antal + 1));
			}

			int temp;

			var watch = Stopwatch.StartNew();

			for (int i = 0; i < lista.Count - 1; i++)
			{
				for (int j = 0; j < lista.Count - 1 - i; j++)
				{
					if (lista[j] > lista[j + 1])
					{
						temp = lista[j + 1];
						lista[j + 1] = lista[j];
						lista[j] = temp;
					}
				}
			}
			watch.Stop();

			foreach (int element in lista)
			{
				Console.WriteLine(element);
			}
			Console.WriteLine();
			Console.WriteLine(watch.ElapsedMilliseconds);
		}
	}
}
