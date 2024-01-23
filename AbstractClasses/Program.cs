using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            string input = Console.ReadLine();

            while(input == "c" || input == "q" || input == "s")
            {
                if (input == "c")
                {
                    Console.Write("Enter radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    Shape circle = new Circle(radius);
                    shapes.Add(circle);
                }
                else if (input == "q") 
                {
                    Console.Write("Enter side: ");
                    double side = double.Parse(Console.ReadLine());
                    Shape square = new Square(side);
                    shapes.Add(square);
                }
                else
                {
                    Console.Write("Enter radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    Shape sphere = new Sphere(radius);
                    shapes.Add(sphere);
                }
                input = Console.ReadLine();
            }
            foreach (Shape shape in shapes) 
            {
                shape.Print();
            }
        }
    }
}
