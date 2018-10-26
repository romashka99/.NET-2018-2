using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public interface ISeries
        {
            double GetCurrent();
            bool MoveNext();
            void Reset();
        }
        public class GeometricalProgression : ISeries
        {
            double q;
            double b;
            int index;

            public GeometricalProgression(double b, double q)
            {
                this.q = q;
                this.index = 1;
                this.b = b;
            }

            public double GetCurrent()
            {
                return b = b * q;
            }

            public bool MoveNext()
            {
                index++;
                return true;
            }

            public void Reset()
            {
                index = 1;
            }


        }
        static void PrintSeries(ISeries series)
        {
            series.Reset();

            for (int i = 0; i < 10; i++)
            {
                Console.Write(series.GetCurrent() + " ");
                series.MoveNext();
            }
        }
        static void Main(string[] args)
        {
            ISeries progression = new GeometricalProgression(2, 2);
            Console.Write("Progression: ");
            PrintSeries(progression);
            Console.ReadKey();
        }
    }
}
