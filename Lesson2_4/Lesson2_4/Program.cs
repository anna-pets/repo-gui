using System;
using System.Collections.Generic;

namespace Lesson2_4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.UTF8;

			var check = new List<(DateTime Date, string Name, double Price)>();


			check.Add((Date: DateTime.Now, Name: "молоко", Price: 30));
			check.Add((DateTime.Now, "капуста", 3));
			check.Add((DateTime.Now, "банан", 55.50));
			check.Add((DateTime.Now, "яблоко", 43.50));
			check.Add((DateTime.Now, "сыр", 220));

			foreach (var keyValue in check)
			{
				Console.WriteLine(keyValue.Date + "     " + keyValue.Name + "     " + keyValue.Price);
			}
		}
	}
}
