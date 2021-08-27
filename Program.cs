using System;

namespace ShapeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Double width, hight, radius;
            System.Console.WriteLine("width");
            width = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("hight");
            hight = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("radius");
            radius = Convert.ToDouble(Console.ReadLine());
            var circle = new Circle(radius);
            System.Console.WriteLine("Area of circle");
            System.Console.WriteLine(circle.Area());
            circle.DrawShape();
            var triangle=new Triangle(width,hight);
            System.Console.WriteLine("Area of triangle");
            System.Console.WriteLine(triangle.TriangleArea());
            triangle.DrawShape();
            var square=new Square(width);
            System.Console.WriteLine("Area of square");
            System.Console.WriteLine(square.Area()); 
            square.DrawShape();
            Console.ReadKey();
        }
    }
}
