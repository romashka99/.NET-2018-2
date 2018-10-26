namespace Task1
{
    partial class Program
    {
        abstract class Figure
        {
            public double X { get; set; }
            public double Y { get; set; }
            protected Figure(double x, double y)
            {
                X = x;
                Y = y;
            }
            public void Draw(IPrinter p, string figure)
            {
                p.Print(X, Y, figure);
            }
        }
    }
}
