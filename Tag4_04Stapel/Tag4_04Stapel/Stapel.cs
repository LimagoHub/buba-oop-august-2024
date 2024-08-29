using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de.buba.collections
{
    public class Stapel
    {

        private int[] data;
        private int index;
        public Stapel()
        {
            data = new int[10];
            index = 0;
        }
        /// <summary>
        /// Fachliche Dokumentation
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value) // Verhalten im Fehlerfall
        {
            if (IsFull) return;
            data[index++] = value;


        }

        public int Pop()
        {
            if (IsEmpty) return 0;
        
            return data[--index];
        }

        public bool IsEmpty
        {
            get => index <= 0;
        }
        public bool IsFull
        {
            get => index >= data.Length;
        }
    }
}
