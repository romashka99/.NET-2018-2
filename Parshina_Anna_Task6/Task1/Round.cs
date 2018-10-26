using System;

namespace Task1
{
    partial class Program
    {
        class Round : Figure
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

            public Round(double x, double y, double radius) : base(x, y)
            {
                Radius = radius;
            }
            void Draw()
            {

            }
        }
    }
}
