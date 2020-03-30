using System.Runtime.Serialization;

namespace System
{
    [Serializable]
    internal class wrongNumber : Exception
    {
        public wrongNumber()
        {
        }

        public wrongNumber(string message) : base(message)
        {
        }

        public wrongNumber(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected wrongNumber(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}