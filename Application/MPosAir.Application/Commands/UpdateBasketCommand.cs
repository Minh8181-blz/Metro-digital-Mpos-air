using MediatR;
using MPosAir.Application.Dtos;

namespace MPosAir.Application.Commands
{
    public class UpdateBasketCommand : IRequest<BasketDto>
    {
        public UpdateBasketCommand(long id, string status)
        {
            BasketId = id;
            Status = status;
        }

        public long BasketId { get; set; }
        public string Status { get; set; }
    }
}
