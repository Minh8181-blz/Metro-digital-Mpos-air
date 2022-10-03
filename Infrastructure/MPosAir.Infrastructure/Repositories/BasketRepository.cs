using Microsoft.EntityFrameworkCore;
using MPosAir.Application.Repositories;
using MPosAir.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace MPosAir.Infrastructure.Repositories
{
    public class BasketRepository : IBasketRepository
    {
        private readonly MPosAirDbContext _context;

        public BasketRepository(MPosAirDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Basket> AddAsync(Basket entity)
        {
            await _context.Baskets.AddAsync(entity);
            return entity;
        }

        public async Task<Basket> GetAsync(long id)
        {
            var basket = await _context.Baskets
                .Include(x => x.Articles)
                .FirstOrDefaultAsync(o => o.Id == id);

            return basket;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
