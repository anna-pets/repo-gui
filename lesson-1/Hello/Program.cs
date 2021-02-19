using System;

namespace Hello
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("What's your name? ");
			string name = Console.ReadLine();
			Console.WriteLine($"[{DateTime.Now}] Hello, {name}!");

		}
	}
}
