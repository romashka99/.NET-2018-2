using System;

namespace Task1
{
    partial class Program
    {
        class Rectangle : Figure
        {
            private double width;
            public double Width
            {
                get
                {
                    return width;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new Exception("Cторона не может быть отрицательной");
                    }
                    else width = value;
                }
            }
            private double height;
            public double Height
            {
                get
                {
                    return height;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new Exception("Сторона не может быть отрицательной");
                    }
                    else height = value;
                }
            }
            public Rectangle(double x, double y, double w, double h) : base (x, y)
            {
                Width = w;
                Height = h;
            }
            void Draw()
            {

            }
        }
    }
}
