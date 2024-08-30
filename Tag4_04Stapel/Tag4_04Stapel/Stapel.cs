using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de.buba.collections
{
    public class Stapel<T>: IStapel<T>
    {
        private const int DEFAULT_SIZE = 10;
        private T[] data;
        private int index;
        

        public Stapel():this(DEFAULT_SIZE)
        {
           
        }

        public Stapel(int size)
        {
            try
            {
                
                data = new T[size];
                index = 0;
            }
            catch (Exception e)
            {
                throw new StapelException("Init",e);
            }
        }
        public bool IsEmpty
        {
            get => index <= 0;
        }
        public bool IsFull
        {
            get => index >= data.Length;
        }

        public void Push(T value) // Verhalten im Fehlerfall
        {
            if (IsFull) throw new StapelException("Overflow"); ;
            data[index++] = value;


        }

        public T? Pop()
        {
            if (IsEmpty) throw new StapelException("Underflow");

            return data[--index];
        }
    }
}
