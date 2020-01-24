using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Merge_sort
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> lista = new List<int>();

			Random random = new Random();

			int amount = 10;

			for (int i = 0; i < amount; i++)
			{
				lista.Add(random.Next(0, amount + 1));
			}

			var stopwatch = Stopwatch.StartNew();

			QuickSort(lista, 0, lista.Count-1);

			stopwatch.Stop();

			foreach (int element in lista)
			{
				Console.WriteLine(element);
			}
			Console.WriteLine();
			Console.Write("Tid: " + stopwatch.ElapsedMilliseconds);
		}

		static void QuickSort(List<int> l, int start, int end)
		{
			int i;
			if (start < end)
			{
				i = Partition(l, start, end);

				QuickSort(l, start, i - 1);
				QuickSort(l, i + 1, end);
			}
		}
		static int Partition(List<int> l, int start, int end)
		{
			int temp;
			int p = l[end];
			int i = start - 1;
			for(int j = start; j <= end - 1; j++)
			{
				if (l[j] <= p)
				{
					i++;
					temp = l[i];
					l[i] = l[j];
					l[j] = temp;
				}
			}
			temp = l[i + 1];
			l[i + 1] = l[end];
			l[end] = temp;
			return i + 1;
		}
	}
}
