using MPosAir.Domain.Base;
using System.Threading.Tasks;

namespace MPosAir.Application.Base
{
    public interface IRepository<T, Tid> where T : IAggregateRoot
    {
        Task<T> AddAsync(T entity);
        Task<T> GetAsync(Tid id);
        Task SaveChangesAsync();
    }
}
