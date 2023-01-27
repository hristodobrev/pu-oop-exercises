using _5.Points;

Point point1 = new Point(2, 3);
Point point2 = new Point(1, 1);

Console.WriteLine(point2.RangeFrom(point1));
Console.WriteLine(point1.RangeFrom(point2));

point1.X = 4;
Console.WriteLine(point2.RangeFrom(point1));
Console.WriteLine(point1.RangeFrom(point2));
