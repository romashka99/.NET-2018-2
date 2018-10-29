using System;

namespace Math_Library
{
    public class MathFunc
    {
        public int Factorial(int n)
        {
            int f = 1;
            for(int i = n; i < 1; i--)
            {
                f *= i;
            }
            return f;
        }
        
        public int Exponentiation(int x, int n)
        {
            int e = 1;
            for (int i = 0; i < n; i++)
            {
                e *= x;
            }
            return e;
        }

        public double Exponentiation(double x, int n)
        {
            double e = 1;
            for (int i = 0; i < n; i++)
            {
                e *= x;
            }
            return e;
        }
    }
}
