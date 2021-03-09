using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Text.RegularExpressions;
using System.Transactions;

namespace Lesson4_2
{
	class Program
	{
		/*Написать программу, принимающую на вход строку — набор чисел,
		 разделенных пробелом, и возвращающую число — сумму всех чисел в строке. Ввести данные с клавиатуры и вывести результат на экран.
        */
		static void Main(string[] args)
		{
			// получаю текст с консоли
			Console.OutputEncoding = Encoding.UTF8;
			Console.WriteLine("Введите числа через пробел");
			string input = Console.ReadLine();


			int a = GetSum(input);
			Console.WriteLine(a);

			Console.ReadLine();
		}

		static int GetSum(string input)
		{
			// делю на слова
			string[] words = input.Split(' ');
			int a = 0;

			// перебираю каждое слово
			for (int i = 0; i < words.Length; i++)
			{
				string currentWord = words[i];

				int currentNumber = int.TryParse(currentWord, out int num)
					? num
					: 0;

				//if (!int.TryParse(currentWord, out currentNumber))
				//{
				//	continue;
				//}


				a = a + currentNumber;
			}

			return a;
		}
	}
}
