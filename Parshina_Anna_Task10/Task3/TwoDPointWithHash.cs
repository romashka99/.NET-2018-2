namespace Task3
{
    class TwoDPointWithHash : TwoDPoint
    {
        public TwoDPointWithHash(int x, int y) : base(x, y)
        { }

        public override int GetHashCode()
        {
            if (x == 0) return (y/2) * y;
            if (y == 0) return (x/2) * x;
            //return x == y ? x * (x / 3) : x * y;
            return x == y? (x/2) * x * x : (x * (y / 2))^(x ^ y);
        }


    }
}
