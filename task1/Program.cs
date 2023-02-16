class Program
{
	static void Main(string[] args)
	{
		int hour, minute;
		while (true)
		{
			Console.Write("Enter the hour in 12 hour format (1-12): ");
			if (int.TryParse(Console.ReadLine(), out hour) && hour >= 1 && hour <= 12)
			{
				break;
			}
			Console.WriteLine("Invalid input! Enter a number between 1-12");
		}
		while (true)
		{
			Console.Write("Enter the minute (0-59): ");
			if (int.TryParse(Console.ReadLine(), out minute) && minute >= 0 && minute <= 59)
			{
				break;
			}
			Console.WriteLine("Invalid input! Please enter a number between 0 and 59");
		}

		double minuteArrow = 6 * minute;
		double hourArrow = 0.5 * (hour * 60 + minute);

		double angleBetweenArrows = Math.Abs(hourArrow - minuteArrow);

		double lesserAngle = Math.Min(angleBetweenArrows, 360 - angleBetweenArrows);

		Console.Write(lesserAngle);
		Console.ReadLine();
	}
}