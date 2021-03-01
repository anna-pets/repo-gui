using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Lesson3_1
{

	public class EnumConversionExample
	{
		public static void Main()
		{

			int[,] matrix = new int[3, 3]
			{
				{0, 1, 2},
				{3, 4, 5},
				{6, 7, 8}
			};


			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					if (i == j)
					{
						Console.Write($"{matrix[i, j]}");
					}

					Console.Write("\t");
				}

				Console.WriteLine();
			}





			/* Написать программу, выводящую элементы двухмерного массива по диагонали. */


			/*int[,] myArray = new int[,]
			{
			{2, 45, 12, 51, 51},
			{6, 7, 8, 3, 1},
			{1, 5, 65, 78, 13},
			{6, 3, 151, 5, 65},
			{64, 43, 15, 5, 37}
			};
			for (int i = 0; i < myArray.Length; i++)
			{
			Console.WriteLine(myArray[i, i].ToString().PadLeft(i * 3));
			}
			*/
			/*int[] array = {1, 2, 3, 4, 5};

			for (int i = array.Length -1; i>= 0; i--)
			{
			Console.WriteLine(array[i]);
			}

			Console.ReadLine();
			*/



		}
	}

}