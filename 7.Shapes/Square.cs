namespace _7.Shapes
{
    public class Square : Shape
    {
        private int side;
        public int Side
        {
            get { return this.side; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Side cannot be negative number");

                this.side = value;
            }
        }

        public Square(int side)
        {
            this.Side = side;
        }

        public override double Area()
        {
            return this.Side * this.Side;
        }

        public override double Perimeter()
        {
            return this.Side * 4;
        }
    }
}
