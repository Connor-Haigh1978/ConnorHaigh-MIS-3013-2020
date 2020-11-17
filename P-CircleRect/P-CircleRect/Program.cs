using System;
using System.Collections.Generic;
namespace P_CircleRect
{
    class Program
    {
        static void Main(string[] args)
        {

            Rectangle myRectangle = new Rectangle();
            myRectangle.Length = 10;
            myRectangle.Width = 9;
            Console.WriteLine($"The length of the rectangle is {myRectangle.Length} The width of the rectangle is {myRectangle.Width}\nThe area of the rectangle is {myRectangle.CalculateArea()} \nThe perimeter of the rectangle is {myRectangle.CalculatePerimeter()} ");

            Circle myCircle = new Circle();
            myCircle.Radius = 10;
            Console.WriteLine($"\nThe area of a circle with a radius of {myCircle.Radius} is {myCircle.CalculateArea()}");
            Console.WriteLine($"The area of a circle with a radius of {myCircle.Radius} is {myCircle.CalculatePerimeter()}");

            Console.ReadKey();
        }
    }
}
