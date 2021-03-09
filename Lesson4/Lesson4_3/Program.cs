using System;
using System.Text;

namespace Lesson4_3
{
	enum Season
	{
		Winter,
		Spring,
		Summer,
		Autumn,
		Unknown
	}

	enum Month

	{
		January,
		February,
		March,
		April,
		May,
		June,
		July,
		August,
		September,
		October,
		November,
		December
	}

	class Program
	{
		static void WrongNumber()
		{
			Console.WriteLine("wrong number");
		}

		static Season GetUserChoice(int monthNumber)
		{
			if (monthNumber == 1|| monthNumber == 2 || monthNumber == 12)
			{
				return Season.Winter;
			}

			
			if (monthNumber == 3 || monthNumber ==4|| monthNumber == 5)
			{
				return Season.Spring;
			}

			
			if (monthNumber == 6|| monthNumber == 7|| monthNumber == 8)
			{
				return Season.Summer;
			}

			if (monthNumber == 9|| monthNumber == 10 || monthNumber == 11)
			{
				return Season.Autumn;
			}
			
			return Season.Unknown;
		}


		static void Main(string[] args)

		{
			/*Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
			На выходе — значение из перечисления (enum) —  Winter, Spring, Summer, Autumn.
			Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень). 
			Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года. Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
			
			 * написать цикл с номерами 1 - 13 и вывести сезон для каждого значения
			 * сделать новую функцию GetUserChoice2 с `switch(){ case: }`, сравнить результаты с GetUserChoice
			 * использовать Month.January вместо 1, Month.February вместо 2,...
			 */
			Console.OutputEncoding=Encoding.UTF8;
			// получила число с клавиатуры
			Console.WriteLine("Введите порядковый номер месяца (1-12): ");
			int monthNumber = Convert.ToInt32(Console.ReadLine());


			// номер месяца -> сезон
			Season season = GetUserChoice(monthNumber);

			Console.WriteLine(season);
			
		}
	}
}
