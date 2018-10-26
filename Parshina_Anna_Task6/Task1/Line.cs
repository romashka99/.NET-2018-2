using System;

namespace Task1
{
    partial class Program
    {
        class Line : Figure
        {
            private double length;
            public double Length
            {
                get
                {
                    return length;
                }
                set
                {
                    if (value < 0)
                    {
                        throw new Exception("Длина не может быть отрицательной");
                    }
                    else length = value;
                }
            }
            public Line(double x, double y, double l) : base(x, y)
            {
                Length = l;
            }

            void Draw(IPrinter p, ):base(p)
            { }
        }
    }
}
