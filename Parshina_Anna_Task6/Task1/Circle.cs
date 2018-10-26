using System;

namespace Task1
{
    partial class Program
    {
        class Circle : Figure
        {
            private double radius;
            public double Radius
            {
                get
                {
                    return radius;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new Exception("Радиус не может быть отрицательным");
                    }
                    else radius = value;
                }
            }
            public Circle(double x, double y, double r) : base(x, y)
            {
                Radius = r;
            }
            void Draw()
            {

            }
        }
    }
}
