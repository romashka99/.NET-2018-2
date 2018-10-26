using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Round
    {
        public double X { get; set; }
        public double Y { get; set; }
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

        public Round(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        public double Length()
        {
            return 2 * Math.PI * radius;
        }

        public double Square()
        {
            return Math.PI * radius * radius;
        }

    }

    class Ring : Round
    {
        private Round External;
        private Round Interior;

        private bool ChackRing(double r1, double r2)
        {
            if (r1 > r2)
                return true;
            else
            {
                throw new Exception("Внутренний радиус не может быть больше внешнего");
            }
        }

        Ring(double x, double y, double r1, double r2) : base(x, y, r1)
        { 
            if (ChackRing(r1, r2))
            {
                External = new Round(x, y, r1);
                Interior = new Round(x, y, r2);
            }
        }

        public double LengthRing()
        {
            double l1 = External.Length();
            double l2 = External.Length();
            return l1 -l2;
        }

        public double SquareRing()
        {
            double l1 = External.Square();
            double l2 = External.Square();
            return l1 - l2;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
