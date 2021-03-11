using System;
using System.IO;


class Program
/*Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.*/
{
	public static void Main(string[] args)
	{
		// создаем каталог для файла
		string dir = @"C:\SomeDir";
		DirectoryInfo dirInfo = new DirectoryInfo(dir);
		if (!dirInfo.Exists)
		{
			dirInfo.Create();
		}
		Console.WriteLine("Please, enter the text: ");
		var inputText = Console.ReadLine();

		// запись в файл
		var path = @"C:\SomeDir\task1_1.txt";
		File.WriteAllLines(path, new[] { inputText });
		
		// чтение из файла
		using (StreamReader sr = File.OpenText(path))
		{
			string s;
			while ((s = sr.ReadLine()) != null)
			{
				Console.WriteLine(s);
			}
		}

		Console.ReadLine();
	}
}
