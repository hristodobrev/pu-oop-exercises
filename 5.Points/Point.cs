namespace _5.Points
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public double RangeFrom(Point point)
        {
            double range = Math.Sqrt(
                Math.Pow(point.X - this.X, 2) +     
                Math.Pow(point.Y - this.Y, 2)    
            );

            return range;
        }
    }
}
