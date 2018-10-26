using System;

namespace Task1
{
    partial class Program
    {
        class Ring : Figure
        {
            private double ExternalRadius;
            private double InteriorRadius;

            private bool ChackRing(double r1, double r2)
            {
                if (r1 > 0 && r2 > 0)
                {
                    if (r1 > r2)
                        return true;
                    else
                    {
                        throw new Exception("Внутренний радиус не может быть больше внешнего");
                    }
                }
                else
                {
                    throw new Exception("Радиусы не могут быть отрицательными или равными нулю");
                }
            }

            public Ring(double x, double y, double r1, double r2) : base(x, y)
            {
                /*X = x;
                  Y = y;*/
                if (ChackRing(r1, r2))
                {
                    ExternalRadius = r1;
                    InteriorRadius = r2;
                }
            }
            void Draw()
            {

            }
        }
    }
}
