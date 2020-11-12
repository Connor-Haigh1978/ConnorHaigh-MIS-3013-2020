using System;
using System.Collections.Generic;
using System.Text;

namespace P_CircleRect
{
    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double CalculateArea()
        {
            double result = Length * Width;
            return result;
        }
        public double CalculatePerimeter()
        {
            double result = 2*(Width * Length);
            return result;
        }
        

    }
}
