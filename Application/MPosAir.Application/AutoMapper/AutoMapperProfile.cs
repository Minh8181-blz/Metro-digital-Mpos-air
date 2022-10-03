using AutoMapper;
using MPosAir.Application.Dtos;
using MPosAir.Domain.Entities;

namespace MPosAir.Application.AutoMapper
{
    internal class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Basket, BasketDto>();
            CreateMap<Article, ArticleDto>()
                .ForMember(dest => dest.Article,
                    options => options.MapFrom(src => src.Name));
        }
    }
}
