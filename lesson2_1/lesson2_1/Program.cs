using System;

namespace lesson2
{
	class Program
	{
		static void Main(string[] args)
		{
		Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.Write("Введите максимальную температуру за сутки: ");
			int max = Convert.ToInt32(Console.ReadLine());

			Console.Write("Введите минимальную температуру за сутки: ");
			int min = Convert.ToInt32(Console.ReadLine());

			int average = (min + max) / 2;

			Console.WriteLine( ("Средняя температура за сутки= ")  + (average));



		}
	}
}
