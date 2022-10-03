using MPosAir.Domain.Base;

namespace MPosAir.Domain.DomainExceptions
{
    public class PriceNegativeDomainException : DomainException
    {
        public PriceNegativeDomainException(decimal price) : base("Price must not be negative")
        {
            Price = price;
        }

        public decimal Price { get; set; }
    }
}
