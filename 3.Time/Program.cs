using _3.Time;


try
{
    Time time1 = new Time(4, 2, 1);
    Console.WriteLine(time1);

    Time time2 = new Time();
    time2.Hours = 14;
    time2.Minutes = 52;
    time2.Seconds = 1;
    time2.Hours++;
    time2.Hours++;
    time2.Hours++;
    time2.Hours++;
    Console.WriteLine(time2);

    Time time3 = new Time(41, 2, 1);
    Console.WriteLine(time3);
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}