

namespace Week1ObjectOriented.Classes
{
    public class Circle : Shape,IShape

    {
        private double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public Circle() { }

        public void SetRadius(double r)
        {
            radius = r;
        }
        //extend the circle class so that it also implements the GetArea()
        public override double GetArea()
        {
            return Math.PI*radius*radius;
        }
        //getarea for IShape
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

}
