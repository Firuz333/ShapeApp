namespace ShapeApp
{
    public class Circle : Shape
    {
        double p = 3.14;
        private double _radius;
        public Circle(double radius):base(0,0)
        {
            _radius = radius;
        }
        public void DrawShape()
        {
            System.Console.WriteLine("       *********       ");
            System.Console.WriteLine("    ***         ***    ");
            System.Console.WriteLine("   **             **   ");
            System.Console.WriteLine(" **                 ** ");
            System.Console.WriteLine(" **                 ** ");
            System.Console.WriteLine(" *                   * ");
            System.Console.WriteLine(" **                 ** ");
            System.Console.WriteLine(" **                 ** ");
            System.Console.WriteLine("   **             **   ");
            System.Console.WriteLine("    ***         ***    ");
            System.Console.WriteLine("       *********       ");
        }
        public double Area()
        {
            return _radius * _radius * p;
        }

    }
}