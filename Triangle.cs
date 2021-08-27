namespace ShapeApp
{
    public class Triangle : Shape
    {
        public Triangle(double width, double hight) : base(width, hight)
        {
            _width=width;
            _hight=hight;
        }
        public void DrawShape()
        {
            System.Console.WriteLine("     *     ");
            System.Console.WriteLine("    * *    ");
            System.Console.WriteLine("   *   *   ");
            System.Console.WriteLine("  *     *  ");
            System.Console.WriteLine(" * * * * * ");
        }
        public double TriangleArea()
        {
            return _width * _hight / 2;
        }


    }
}