using AutoMapper;
using MediatR;
using MPosAir.Application.Dtos;
using MPosAir.Application.Queries;
using MPosAir.Application.Repositories;
using System.Threading;
using System.Threading.Tasks;

namespace MPosAir.Application.Commands
{
    public class GetBasketByIdQueryHandler : IRequestHandler<GetBasketByIdQuery, BasketDto>
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IMapper _mapper;

        public GetBasketByIdQueryHandler(IBasketRepository basketRepository, IMapper mapper)
        {
            _basketRepository = basketRepository;
            _mapper = mapper;
        }

        public async Task<BasketDto> Handle(GetBasketByIdQuery request, CancellationToken cancellationToken)
        {
            var basket = await _basketRepository.GetAsync(request.Id);
            return _mapper.Map<BasketDto>(basket);
        }
    }
}
