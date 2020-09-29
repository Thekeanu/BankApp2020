using System;
using System.Runtime.Serialization;

namespace BankLibrary
{
    [Serializable]
    internal class AmountException : Exception
    {
        public AmountException()
        {
        }

        public AmountException(string message) : base(message)
        {
        }

        public AmountException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AmountException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}