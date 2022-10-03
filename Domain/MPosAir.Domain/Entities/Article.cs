using MPosAir.Domain.Base;
using System;

namespace MPosAir.Domain.Entities
{
    public class Article : EntityBase
    {
        public Article(string name, decimal price)
        {
            Name = name;
            Price = price;
            CreatedAt = DateTime.UtcNow;
            LastUpdatedAt = DateTime.UtcNow;
        }

        public long BasketId { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
    }
}
