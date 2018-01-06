using System;

namespace SOLIDLSP
{
    public class Quadrilaterals
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

        public int Area()
        {
            return Height * Width;
        }
    }

    public class Rectangle : Quadrilaterals
    {
        public override int Width
        {
            get { return base.Width; }
            set { base.Width = value; }
        }
        public override int Height
        {
            get { return base.Height; }
            set { base.Height = value; }
        }

    }

    public class Square : Quadrilaterals
    {
        public override int Height
        {
            get { return base.Height; }
            set { SetWidthAndHeight(value); }
        }

        public override int Width
        {
            get { return base.Width; }
            set { SetWidthAndHeight(value); }
        }

        private void SetWidthAndHeight(int value)
        {
            base.Height = value;
            base.Width = value;
        }

    }


    public class AreaCalculator
    {
        public void GetArea()
        {
            Quadrilaterals shape;                

            shape = new Square();
            shape.Height = 10;
            shape.Width = 5;
            
            Console.WriteLine("Area={0}", shape.Area()); // ??
            Console.ReadLine();
        }
    }







}
