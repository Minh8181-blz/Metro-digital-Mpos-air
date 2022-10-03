using AutoMapper;
using MediatR;
using MPosAir.Application.Dtos;
using MPosAir.Application.Repositories;
using MPosAir.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MPosAir.Application.Commands
{
    public class CreateBasketCommandHandler : IRequestHandler<CreateBasketCommand, BasketDto>
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IMapper _mapper;

        public CreateBasketCommandHandler(IBasketRepository basketRepository, IMapper mapper)
        {
            _basketRepository = basketRepository;
            _mapper = mapper;
        }

        public async Task<BasketDto> Handle(CreateBasketCommand request, CancellationToken cancellationToken)
        {
            var basket = Basket.Init(request.Customer, request.PaysVAT);
            await _basketRepository.AddAsync(basket);
            await _basketRepository.SaveChangesAsync();
            return _mapper.Map<BasketDto>(basket);
        }
    }
}
