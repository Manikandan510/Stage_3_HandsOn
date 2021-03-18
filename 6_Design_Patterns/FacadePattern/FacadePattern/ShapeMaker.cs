using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public class ShapeMaker
    {
        public Shape circle;
        public Shape rectangle;
        public Shape square;

        public ShapeMaker()
        {}

        public void drawCircle() 
        {
            circle = new Circle();
            circle.draw();
        }
        public void drawRectangle()
        {
            circle = new Rectangle();
            circle.draw();
        }
        public void drawSquare()
        {
            circle = new Square();
            circle.draw();
        }
    }
}
