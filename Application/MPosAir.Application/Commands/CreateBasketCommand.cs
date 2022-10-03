using MediatR;
using MPosAir.Application.Dtos;

namespace MPosAir.Application.Commands
{
    public class CreateBasketCommand : IRequest<BasketDto>
    {
        public CreateBasketCommand(string customer, bool paysVat)
        {
            Customer = customer;
            PaysVAT = paysVat;
        }

        public string Customer { get; set; }
        public bool PaysVAT { get; set; }
    }
}
