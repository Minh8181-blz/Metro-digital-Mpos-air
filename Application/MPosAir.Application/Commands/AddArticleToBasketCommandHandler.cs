using AutoMapper;
using MediatR;
using MPosAir.Application.Dtos;
using MPosAir.Application.Exceptions;
using MPosAir.Application.Repositories;
using MPosAir.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace MPosAir.Application.Commands
{
    public class AddArticleToBasketCommandHandler : IRequestHandler<AddArticleToBasketCommand, BasketDto>
    {
        private readonly IBasketRepository _basketRepository;
        private readonly IMapper _mapper;

        public AddArticleToBasketCommandHandler(IBasketRepository basketRepository, IMapper mapper)
        {
            _basketRepository = basketRepository;
            _mapper = mapper;
        }

        public async Task<BasketDto> Handle(AddArticleToBasketCommand request, CancellationToken cancellationToken)
        {
            var basket = await _basketRepository.GetAsync(request.BasketId);
            if (basket == null)
                throw new EntityNotFoundException(nameof(Basket), request.BasketId);

            basket.AddArticle(request.ArticleName, request.Price);
            await _basketRepository.SaveChangesAsync();
            return _mapper.Map<BasketDto>(basket);
        }
    }
}
