using MediatR;
using MPosAir.Application.Dtos;

namespace MPosAir.Application.Queries
{
    public class GetBasketByIdQuery : IRequest<BasketDto>
    {
        public GetBasketByIdQuery(long id)
        {
            Id = id;
        }

        public long Id { get; set; }
    }
}
