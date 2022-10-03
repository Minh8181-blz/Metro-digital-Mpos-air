using MediatR;
using Microsoft.AspNetCore.Mvc;
using MPosAir.Application.Commands;
using MPosAir.Application.Dtos;
using MPosAir.Application.Queries;
using MPosAir.WebAPI.Models;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace MPosAir.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BasketsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<BasketDto> Get(long id)
        {
            var query = new GetBasketByIdQuery(id);
            var basket = await _mediator.Send(query);
            if (basket == null)
                Response.StatusCode = (int)HttpStatusCode.NotFound;
            return basket;
        }

        [HttpPost]
        public async Task<BasketDto> Post([FromBody] CreateBasketModel model)
        {
            var command = new CreateBasketCommand(model.Customer, model.PaysVAT);
            var basket = await _mediator.Send(command);
            return basket;
        }

        [HttpPut("{id}")]
        public async Task<BasketDto> Update(long id, [FromBody] UpdateBasketModel model)
        {
            var command = new UpdateBasketCommand(id, model.Status);
            var basket = await _mediator.Send(command);
            return basket;
        }


        [HttpPost("{id}/article-line")]
        public async Task<BasketDto> AddArticleLine(long id, [FromBody] AddArticleToBasketModel model)
        {
            var command = new AddArticleToBasketCommand(id, model.Article, model.Price);
            var basket = await _mediator.Send(command);
            return basket;
        }
    }
}
