using System;

namespace Lesson2_4
{
	class CheckItem
	{
		public DateTime Date;
		public string Name;
		public double Price;

		public string GetLine()
		{
			return $"{Date.ToString("G").PadRight(20)}  {Name.PadRight(10)} {Price}";
		}
	}
}
