using MediatR;
using MPosAir.Application.Dtos;

namespace MPosAir.Application.Commands
{
    public class AddArticleToBasketCommand : IRequest<BasketDto>
    {
        public AddArticleToBasketCommand(long basketId, string name, decimal price)
        {
            BasketId = basketId;
            ArticleName = name;
            Price = price;
        }

        public long BasketId { get; set; }
        public string ArticleName { get; set; }
        public decimal Price { get; set; }
    }
}
