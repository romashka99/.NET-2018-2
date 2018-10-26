using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        private double a;
        public double A
        {
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Сторона не может быть отрицательной");
                }
                else a = value;
            }
            get
            {
                return a;
            }
        }
        private double b;
        public double B
        {
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Сторона не может быть отрицательной");
                }
                else b = value;
            }
            get
            {
                return b;
            }

        }
        private double c;
        public double C
        {
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Сторона не может быть отрицательной");
                }
                else c = value;
            }
            get
            {
                return c;
            }
        }

        private bool ChackTriangle(double a, double b, double c)
        {
            if (b + c > a && a + c > b && a + b > c)
                return true;
            return false;
        }

        public Triangle(double a, double b, double c)
        {
            if (ChackTriangle(a,b,c))
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else throw new Exception("Треугольника с такими сторонами не существует");
        }

        public double Perimeter()
        {
            return a + b + c;
        }

        public double GetHeight(double P)
        {
            double p = P / 2;
            return 2 / a * Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public double Square(double P)
        {
            double p = P / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c) );
        }

        public double Square(double h, double side)
        {
            return side * h / 2;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
