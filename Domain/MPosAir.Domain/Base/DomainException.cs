using System;

namespace MPosAir.Domain.Base
{
    public class DomainException : Exception
    {
        public DomainException(string message)
            : base(message)
        { }
    }
}
