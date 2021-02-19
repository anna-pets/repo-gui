using System;

namespace Lesson2_3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.Write("Введите число: ");
			int a = Convert.ToInt32(Console.ReadLine());
			if (a % 2 == 0)
			{
				Console.WriteLine($"Число чётное");
			}
			else
			{
				Console.WriteLine($"Число нечётное");
			}
		}
	}
}
