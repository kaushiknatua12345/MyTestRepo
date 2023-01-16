using System;
using System.Runtime.Serialization;

namespace Calculator.Tests
{
    [Serializable]
    internal class NotImplememtedCustomException : Exception
    {
        public NotImplememtedCustomException()
        {
        }

        public NotImplememtedCustomException(string message) : base(message)
        {
        }

        public NotImplememtedCustomException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotImplememtedCustomException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}