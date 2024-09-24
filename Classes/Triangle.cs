using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Triangle : Shape, IShape

    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Color Color { get; set; }

        public Triangle(double @base, double height)
        {
            Base = @base;
            Height = height;
            Color = ShapeColourHelper.GetRandomColor();
        }

        public double GetArea()
        {
            return 0.5 * Base * Height;
        }
       
    }
}
