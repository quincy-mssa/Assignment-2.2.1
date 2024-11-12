namespace Assignment_2._2._1
{
    using System;

    //Parent class
    public class Shape
    {
        //Properties
        //Shape ID
        public string Id { get; set; }

        //Shape Name
        public string Name { get; set; }

        //Shape Color
        public string Color { get; set; }

        public virtual double CalculateArea()
        {
            return 0;
        }
    }

    //child class for circle
    public class Circle : Shape
    {
        public virtual double Radius { get; set; }

        //method to calculate area of a circle
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    //child class for square
    public class Square : Shape
    {
        public double Side { get; set; }
        //method to calculate area of a square
        public override double CalculateArea()
        {
            return Math.Pow(Side, 2);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Choose a shape (Circle/Square): ");
            string shapeType = Console.ReadLine();

            Shape shape;

            if (shapeType.Equals("Circle"))
            {
                shape = new Circle();
                Console.Write("Enter circle radius: ");
                ((Circle)shape).Radius = Convert.ToDouble(Console.ReadLine());
            }
            else if (shapeType.Equals("Square"))
            {
                shape = new Square();
                Console.Write("Enter side length of square: ");
                ((Square)shape).Side = Convert.ToDouble(Console.ReadLine());
            }
            else
            {
                return;
            }

            Console.WriteLine("Enter shape ID: ");
            shape.Id = Console.ReadLine();
            Console.WriteLine("Enter shape name: ");
            shape.Name = Console.ReadLine();
            Console.WriteLine("Enter shape color: ");
            shape.Color = Console.ReadLine();

            Console.WriteLine($"Shape parameters:");
            Console.WriteLine($"ID: {shape.Id}");
            Console.WriteLine($"Name: {shape.Name}");
            Console.WriteLine($"Color: {shape.Color}");
            Console.WriteLine($"Calculated Area: {shape.CalculateArea()}");
        }
    }

}
