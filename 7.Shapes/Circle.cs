namespace _7.Shapes
{
    public class Circle : Shape
    {
        private int radius;
        public int Radius
        {
            get { return this.radius; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Radius cannot be negative number");

                this.radius = value;
            }
        }

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public override double Area()
        {
            return this.Radius * this.Radius * Math.PI;
        }

        public override double Perimeter()
        {
            return 2 * this.Radius * Math.PI;
        }
    }
}
