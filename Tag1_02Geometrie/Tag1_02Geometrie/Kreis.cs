using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometrie
{
    public class Kreis : Punkt
    {
        public double Radius { get; set; }


        public Kreis(): this(0,0,0)
        {   
        }

        public Kreis(double radius):this(radius, 0,0)
        {
         
        }

        public Kreis(double x, double y) : this(0, x, y)
        {
           
        }


        public Kreis(double radius ,double x, double y):base(x,y)
        {
            
            Radius = radius;

        }

        public Kreis(Punkt p):this(0, p.X, p.Y)
        {
            


        }

        public override void Rechts()
        {
            base.Rechts();
            base.Rechts();
        }
        
        public override string ToString()
        {
            return base.ToString() + ", Radius=" + Radius;
        }
        
    }
}
