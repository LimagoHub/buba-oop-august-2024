using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de.buba.collections
{
    public class Stapel
    {
        private const int DEFAULT_SIZE = 10;
        private int[] data;
        private int index;
        public Stapel():this(DEFAULT_SIZE)
        {
           
        }

        public Stapel(int size)
        {
            data = new int[size <1 ?DEFAULT_SIZE: size];
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
