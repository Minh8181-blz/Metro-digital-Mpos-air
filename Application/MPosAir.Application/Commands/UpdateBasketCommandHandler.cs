using AutoMapper;
using MediatR;
using MPosAir.Application.Dtos;
using MPosAir.Application.Exceptions;
using MPosAir.Application.Repositories;
using MPosAir.Domain.Consts;
using MPosAir.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MPosAir.Application.Commands
{
    public class UpdateBasketCommandHandler : IRequestHandler<UpdateBasketCommand, BasketDto>
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IMapper _mapper;

        public UpdateBasketCommandHandler(IBasketRepository basketRepository, IMapper mapper)
        {
            _basketRepository = basketRepository;
            _mapper = mapper;
        }

        public async Task<BasketDto> Handle(UpdateBasketCommand request, CancellationToken cancellationToken)
        {
            var basket = await _basketRepository.GetAsync(request.BasketId);
            if (basket == null)
                throw new EntityNotFoundException(nameof(Basket), request.BasketId);
            if (request.Status == BasketStatus.Closed)
            {
                basket.Close();
                await _basketRepository.SaveChangesAsync();
            }

            return _mapper.Map<BasketDto>(basket);
        }
    }
}
