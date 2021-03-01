using System;
using System.Text;

namespace Lesson3_1
{
	public class EnumConversionExample
				{
					public static void Main()
					{
						/* Написать программу, выводящую введенную пользователем строку в обратном порядке (olleH вместо Hello) */

						Console.OutputEncoding = System.Text.Encoding.UTF8;

						Console.WriteLine("Введите строку: ");
						string line = Console.ReadLine();

						for (int i = line.Length-1; i >= 0; i--)
						{
							Console.Write(line[i]);
						}

						Console.Read();

					}
				}
			}