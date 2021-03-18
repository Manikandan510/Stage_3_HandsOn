using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    public interface Shape
    {
        void draw();
    }
    public class Circle : Shape 
    {
        public void draw() 
        {
            Console.WriteLine("Circle  shape is created");
        }
    }
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle shape is created");
        }
    }
    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Square  shape is created");
        }
    }
}
