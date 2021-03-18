using System;

namespace FacadePattern
{
    class FacadePatternDemo
    {
        static void Main(string[] args)
        {
            ShapeMaker sm = new ShapeMaker();
            sm.drawCircle();
            sm.drawRectangle();
            sm.drawSquare();

            Console.ReadLine();
        }
    }
}
