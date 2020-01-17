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

			int antal = 10000;

			for (int i = 0; i < antal; i++)
			{
				lista.Add(rnd.Next(0, antal + 1));
			}

			var watch = Stopwatch.StartNew();

			for (int i = 1; i < lista.Count; i++)
			{
				int key = lista[i];
				int j = i - 1;
				while (j >= 0 && lista[j] > key)
				{
					lista[j + 1] = lista[j];
					j = j - 1;
				}
				lista[j + 1] = key;
			}

			watch.Stop();

			foreach (int element in lista)
			{
				Console.WriteLine(element);
			}
			Console.WriteLine();
			Console.WriteLine("Tid: " + watch.ElapsedMilliseconds);
		}
	}
}
