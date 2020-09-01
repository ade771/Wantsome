using System;

namespace Shapes
{
    internal partial class Program
    // - Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
    //- Define two new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure(height* width for rectangle and height* width/2 for triangle).
    //- Define class Square and suitable constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
    //- Write a program that tests the behaviour of the CalculateSurface() method for different shapes(Square, Rectangle, Triangle) stored in an array.
    {
        static void Main(string[] args)
        {
            Shape[] shape = new Shape[3];
            shape[0] = new Square(10);
            shape[1] = new Triangle(9, 5);
            shape[2] = new Rectangle(8, 6);



            foreach (var s in shape)
            {

                Console.WriteLine(s.CalculateSurface());
            }
        }
    }
}

