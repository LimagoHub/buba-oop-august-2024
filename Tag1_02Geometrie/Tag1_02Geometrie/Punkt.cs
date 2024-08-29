using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrie
{
    public class Punkt
    {
        private static readonly double MAX = 10.0;
        private double _x, _y;
        public double X
        {
            get => _x;
            private set
            {
                if (value < -MAX || value > MAX) throw new ArgumentException("Häh?");
                _x = value;
                
            } 
        }

        public double Y
        {
            get => _y;
            private set
            {
                if (value < -MAX || value > MAX) throw new ArgumentException("Häh?");
                _y = value;

            }
        }

        public Punkt(double x, double y)
        {
            Console.WriteLine("Dicker Konstruktor");
            X = x;
            Y = y;
        }

        public Punkt():this(0,0)
        {
            Console.WriteLine("Kleiner Konstruktor");
        }

        public void Rechts()
        {
            Rechts(1.0);
        }

        public void Rechts(double offset)
        {
            X+=offset;
            
        }

        public void Links(double offset = 1.0)
        {
            Rechts(-offset);
        }

        public void Oben()
        {
            Y++;
        }
        public void Unten()
        {
            Y--;
        }


        public override string ToString()
        {
            
            return $"{nameof(X)}: {X}, {nameof(Y)}: {Y}";
        }
    }
}
