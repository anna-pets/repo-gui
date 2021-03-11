using System;
using System.IO;


class Program
 /*Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.*/
{


	public static void Main(string[] args)
	{
		// создаем каталог для файла
		string dir = @"C:\SomeDir2";
		DirectoryInfo dirInfo = new DirectoryInfo(dir);
		if (!dirInfo.Exists)
		{
			dirInfo.Create();
		}
		//вводим с клавиатуры произвольный набор чисел
		Console.WriteLine ("Please, enter the numbers: ");
		var inputBytesString = Console.ReadLine();
		//int inputBytesString = Convert.ToInt32(inputText);


		// разделяем строку по пробелам
		string [] inputsArray = inputBytesString.Split(' ', StringSplitOptions.RemoveEmptyEntries);

		// создаем массив для присвоения значений
		var byteArray = new byte[inputsArray.Length];

		// и парсим значения через цикл и заполняем массив
		for (int i = 0; i < inputsArray.Length; i++)
			byteArray[i] = byte.Parse(inputsArray[i]);

		// запись в файл
		var path = @"C:\SomeDir2\task3.bin";
		File.WriteAllBytes(path, byteArray);
		
		Console.ReadLine();
	}
}