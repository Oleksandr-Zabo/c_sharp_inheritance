namespace c_sharp_inheritance
{//lab ex.4

    public abstract class Figure
    {
        public virtual double CalculateArea()
        {
            return 0;
        }

        public virtual string FigureType()
        {
            return "Unknown Figure";
        }
    }

    public class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override string FigureType()
        {
            return "Rectangle";
        }
    }

    public class Circle : Figure
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override string FigureType()
        {
            return "Circle";
        }
    }

    public class RightTriangle : Figure
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public RightTriangle(double baseLength, double height)
        {
            Base = baseLength;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * Base * Height;
        }

        public override string FigureType()
        {
            return "Right Triangle";
        }
    }

    public class Trapezoid : Figure
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Height { get; set; }

        public Trapezoid(double base1, double base2, double height)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }

        public override double CalculateArea()
        {
            return 0.5 * (Base1 + Base2) * Height;
        }

        public override string FigureType()
        {
            return "Trapezoid";
        }
    }

    internal class Program
    {
        static void Main()
        {
            Figure[] figures = new Figure[]
            {
                new Rectangle(5, 10),
                new Circle(7),
                new RightTriangle(3, 4),
                new Trapezoid(3, 5, 4)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine($"Figure: {figure.FigureType()}, Area: {figure.CalculateArea()}");
            }
        }
    }
}
