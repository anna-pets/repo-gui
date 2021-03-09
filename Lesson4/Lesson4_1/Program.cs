using System;

namespace Lesson4_1
{
	class Program


		/*Написать метод GetFullName(string firstName, string lastName, string patronymic),
		 принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
		Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО. */
	{
		static void Main(string[] args)
		{

			for (int i = 0; i < 4; i++)
			{
				Console.WriteLine("What is your firstName?");
				string firstName = Console.ReadLine();
				Console.WriteLine("What is your lastName");
				string lastName = Console.ReadLine();
				Console.WriteLine("What is your patronymic");
				string patronymic = Console.ReadLine();
				string fullName = GetFullName(firstName, lastName, patronymic);
				Console.WriteLine(fullName);
			}
		}



		static string GetFullName(string firstName, string lastName, string patronymic)
		{

			return $"{firstName}{lastName}{patronymic}";
		}

	}

}
