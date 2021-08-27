namespace ShapeApp
{
    public class Square : Shape
    {
        
        public Square(double width):base(width,0)
        {
            _width = width;
        }

        public void DrawShape()
        {
            System.Console.WriteLine("* * * * * * ");
            System.Console.WriteLine("* * * * * * ");
            System.Console.WriteLine("* * * * * * ");
            System.Console.WriteLine("* * * * * * ");
            System.Console.WriteLine("* * * * * * ");
            System.Console.WriteLine("* * * * * * ");
        }
        public double Area()
        {
            return _width * _width;
        }

    }
}