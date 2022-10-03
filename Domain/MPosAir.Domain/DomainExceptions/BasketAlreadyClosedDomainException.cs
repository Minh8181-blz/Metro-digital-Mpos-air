using MPosAir.Domain.Base;

namespace MPosAir.Domain.DomainExceptions
{
    public class BasketAlreadyClosedDomainException : DomainException
    {
        public BasketAlreadyClosedDomainException(long id) : base("Basket is already closed")
        {
            BasketId = id;
        }

        public long BasketId { get; set; }
    }
}
