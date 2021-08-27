namespace ShapeApp
{
    public class Shape
    {
        protected double _width;
        protected double _hight;
        public Shape(double width, double hight)
        {
            _width = width;
            _hight = hight;
        }
      
        public virtual double GetArea(){
            return _hight * _width;
        }

    }
}