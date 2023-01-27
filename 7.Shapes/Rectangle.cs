namespace _7.Shapes
{
    public class Rectangle : Shape
    {
        private int a;
        private int b;
        public int A
        {
            get { return this.a; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Side A cannot be negative number");

                this.a = value;
            }
        }
        public int B
        {
            get { return this.b; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Side B cannot be negative number");

                this.b = value;
            }
        }

        public Rectangle(int a, int b)
        {
            this.A = a;
            this.B = b;
        }

        public override double Area()
        {
            return this.A * this.B;
        }

        public override double Perimeter()
        {
            return this.A * 2 + this.B * 2;
        }
    }
}
