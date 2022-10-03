using MPosAir.Domain.Base;
using MPosAir.Domain.Consts;
using MPosAir.Domain.DomainExceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MPosAir.Domain.Entities
{
    public class Basket : EntityBase, IAggregateRoot
    {
        protected Basket() { }

        public static Basket Init(string customer, bool paysVAT)
        {
            var basket = new Basket
            {
                Customer = customer,
                PaysVAT = paysVAT,
                Status = BasketStatus.Active,
                CreatedAt = DateTime.UtcNow,
                LastUpdatedAt = DateTime.UtcNow,
            };
            return basket;
        }

        public ICollection<Article> Articles { get; private set; }
        public decimal TotalNet { get; private set; }
        public decimal TotalGross { get; private set; }
        public string Customer { get; private set; }
        public bool PaysVAT { get; private set; }
        public string Status { get; private set; }

        public void AddArticle(string name, decimal price)
        {
            if (price < 0)
                throw new PriceNegativeDomainException(price);
            if (Status == BasketStatus.Closed)
                throw new BasketAlreadyClosedDomainException(Id);

            Articles ??= new List<Article>();
            var article = new Article(name, price);
            Articles.Add(article);
            CalculateTotals();
            SetLastUpdated();
        }

        public void Close()
        {
            if (Status == BasketStatus.Closed)
                throw new BasketAlreadyClosedDomainException(Id);

            Status = BasketStatus.Closed;
            SetLastUpdated();
        }

        private void CalculateTotals()
        {
            TotalNet = Articles?.Sum(a => a.Price) ?? 0;
            TotalGross = PaysVAT ? (TotalNet + TotalNet / 10) : TotalNet;
        }
    }
}
