using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2_4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = Encoding.UTF8;

			var check = new List<(DateTime Date, string Name, double Price)>
			{
				(Date: DateTime.Now, Name: "молоко", Price: 30),
				(DateTime.Now, "капуста", 3),
				(DateTime.Now, "банан", 55.50),
				(DateTime.Now, "яблоко", 43.50),
				(DateTime.Now, "сыр", 220)
			};

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Дата/Время             Название   Цена ");
			Console.ForegroundColor = ConsoleColor.White;
			for (int index = 0; index < check.Count; index++)
			{
				var keyValue = check[index];
				Console.WriteLine($"{keyValue.Date.ToString("G").PadRight(20)}  {keyValue.Name.PadRight(10)} {keyValue.Price}");
			}
		}
	}
}