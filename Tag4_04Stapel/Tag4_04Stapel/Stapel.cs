using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de.buba.collections
{
    public class Stapel
    {
        public Stapel()
        {
        }
        /// <summary>
        /// Fachliche Dokumentation
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value) // Verhalten im Fehlerfall
        {

        }

        public int Pop()
        {
            return 0;
        }

        public bool IsEmpty
        {
            get => false;
        }
        public bool IsFull
        {
            get => false;
        }
    }
}
