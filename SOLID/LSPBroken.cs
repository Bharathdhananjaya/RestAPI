using System;

namespace SOLID
{
    // Squre is a rectangle ???

    public class Rectangle
    {
        protected int _width;
        protected int _height;
        public int Width
        {
            get { return _width; }
        }
        public int Height
        {
            get { return _height; }
        }

        public virtual void SetWidth(int width)
        {
            _width = width;
        }
        public virtual void SetHeight(int height)
        {
            _height = height;
        }
        public int getArea()
        {
            return _width * _height;
        }
    }

    public class Square : Rectangle  
    {
        public override void SetWidth(int width)
        {
            _width = width;
            _height = width;
        }

        public override void SetHeight(int height)
        {
            _height = height;
            _width = height;
        }
    }

    public class AreaCalculator
    {
        public void GetArea()
        {
           Rectangle shape; 

            shape = new Square();
            shape.SetWidth(5);
            shape.SetHeight(10);
            Console.WriteLine("Area={0}", shape.getArea()); // ??
            Console.ReadLine();
        }
    }

    public class ShareFactory
    {
        public Rectangle GetArea()
        {
            return new Square();
        }
    }





}
