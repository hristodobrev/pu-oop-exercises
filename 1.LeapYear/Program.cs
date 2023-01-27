int year = int.Parse(Console.ReadLine());

if (year % 4 == 0)
{
	if (year % 100 == 0)
	{
		if (year % 400 == 0)
		{
			Console.WriteLine("Leap year.");
		}
		else
		{
			Console.WriteLine("Not a leap year.");
		}
	}
	else
	{
		Console.WriteLine("Leap year.");
	}
}
else
{
	Console.WriteLine("Not a leap year.");
}