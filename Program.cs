using _2._2._1practice;

namespace _2._2._1practice
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Select the shape (Circle or Square):");
            string shapeType = Console.ReadLine().ToLower();
            Shape shape;
            if (shapeType == "circle")
            {
                shape = new Circle();
                Console.WriteLine("Enter the radius of the circle:");
                ((Circle)shape).radius = double.Parse(Console.ReadLine());  
            }
            else if (shapeType == "square")
            {
                shape = new Square();
                Console.WriteLine("Enter the side length of the square:");
                ((Square)shape).SideLength = double.Parse(Console.ReadLine());
                return;
            }
            else
            {
                Console.WriteLine("Invalid shape type.");
                return;
            }

            Console.WriteLine("Enter the ID of the shape:");
            shape.Id = int.Parse(Console.ReadLine());//.Parse used to covert the string to an integer 
            Console.WriteLine("Enter the name of the shape:");
            shape.Name = Console.ReadLine();//User inputs shape name 
            Console.WriteLine("Enter the color of the shape:");
            shape.Color = Console.ReadLine();//User inputs shape color 
            Console.WriteLine($"The area of the {shape.Name} is: {shape.CalculateArea()}");
        }
            
    }
}
