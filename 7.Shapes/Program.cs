using _7.Shapes;

List<Shape> shapes = new List<Shape>();
shapes.Add(new Circle(3));
shapes.Add(new Square(5));
shapes.Add(new Rectangle(5, 2));

foreach (var shape in shapes)
{
    Console.WriteLine($"{shape.GetType().Name} - Area: {shape.Area():0.00}, Perimeter: {shape.Perimeter():0.00}");
}