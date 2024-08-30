using System.Runtime.Serialization;

namespace de.buba.collections
{
    public class StapelException : Exception
    {
        public StapelException()
        {
        }

        protected StapelException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public StapelException(string? message) : base(message)
        {
        }

        public StapelException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
