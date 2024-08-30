using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de.buba.collections
{
    public interface IStapel<T>
    {



        bool IsEmpty { get; }

        public bool IsFull { get; }


        /// <summary>
        /// Fachliche Dokumentation
        /// </summary>
        /// <exception cref=""></exception>
        /// <param name="value"></param>
        public void Push(T value);

        public T? Pop();
    }
}