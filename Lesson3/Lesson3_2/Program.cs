using System;
using Microsoft.VisualBasic;

namespace Lesson3_2
{
	class Program
	{
		static void Main(string[] args)
		{
			/*Написать программу — телефонный справочник — создать двумерный массив 5 * 2,
				 хранящий список телефонных контактов: первый элемент хранит имя контакта,
				 второй — номер телефона/ e - mail.*/
			string[,] phonebook = new string[,]
			{
				{"Ivanov", "+380935471329, Ivanov@gmail.com"},
				{"Petrov", "+380965514412, Petrov@gmail.com"},
				{"Sidorov", "+380975514588, Sidorov@gmail.com"},
				{"Pavlov", "+380975514588, Pavlov@gmail.com"},
				{"Filimonov", "+380975514588, Filimonov@gmail.com"}

			};
			for (int i = 0; i < phonebook.GetLength(0); i++)
			{
				for (int j = 0; j < phonebook.GetLength(1); j++)
				{
					Console.Write(phonebook[i, j].PadRight(15));
				}

				System.Console.WriteLine();
			}


		}
	}
}
