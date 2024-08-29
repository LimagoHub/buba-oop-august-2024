using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de.buba.tiere
{
    public class Schwein : IDisposable
    {
        private string _name;
        private int _gewicht;
        private static int _counter;
        public string Farbe { get; set; }




        // Klassenkonstruktor

        static Schwein()
        {
            Console.WriteLine("Static Ctor");
            _counter = 0;
        }

        // Instanzkonstrutor(en)
        public Schwein():this("Nobody")
        {
        
        }


        public Schwein(string name)
        {
            Name = name;
            Gewicht = 10;
            Schwein.Counter++;
        }

        //// Destruktor -> durch den GC
        //~Schwein()
        //{
        //    Console.WriteLine("Quiek");
        //    Counter--;
        //}

        public static int Counter
        {
            get => _counter;
            private set => _counter = value;
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(value == "Elsa") throw new ArgumentOutOfRangeException("Upps");
                _name = value;
            }
        }

        public int Gewicht
        {
            get
            { 
                return  _gewicht;
            }
            private set
            {
                if (value < 10) throw new ArgumentOutOfRangeException("Upps");
                _gewicht = value;
            }
        }

        public void fuettern()
        {
            Gewicht++;
            
        }

        public override string ToString()
        {
            return "Schwein: Name: "+ Name + ", Gewicht: " + Gewicht;
        }

        public void Dispose()
        {
            Console.WriteLine("Quiek");
            Counter--;
        }
    }
}
