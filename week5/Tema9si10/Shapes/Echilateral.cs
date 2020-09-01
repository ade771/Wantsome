using System;

namespace Shapes
{
    //- Define abstract class Shape with only one abstract method CalculateSurface() and fields width and height.
    //  - Define two le constructor so that at initialization height must be kept equal to width and implement the CalculateSurface() method.
    //  - Write a program that tests the behaviour of the CalculateSurface() method for different shapes(Square, Rectangle, Triangle) stored in an array.
    //new classes Triangle and Rectangle that implement the virtual method and return the surface of the figure(height* width for rectangle and height* width/2 for triangle).
    //  - Define class Square and suitab
    class Echilateral : Triangle
    {
        public Echilateral(double latura) : base(latura, latura * Math.Sqrt(3) / 2)
        {

        }
    }


}

