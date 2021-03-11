using System;
using System.IO;
using System.Text;

class Test

/*Написать программу, которая при старте дописывает текущее время в файл «startup.txt».*/
{
		public static void Main(string[] args)
		{
			// создаем каталог для файла
			string dir = @"C:\SomeDir1";
			DirectoryInfo dirInfo = new DirectoryInfo(dir);
			if (!dirInfo.Exists)
			{
				dirInfo.Create();
			}
			var inputText  = $"{DateTime.Now.ToString()}";


		// запись в файл
		var path = @"C:\SomeDir1\startup.txt";
		File.WriteAllLines(path, new[] { inputText });



		// чтение из файла
		string readText = File.ReadAllText(path);
		Console.WriteLine(readText);

		}
	}
