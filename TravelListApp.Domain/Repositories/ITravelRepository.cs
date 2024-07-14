using TravelListApp.Domain.Entities;

namespace TravelListApp.Domain.Repositories;

public interface ITravelRepository
{
    Task<Travel> GetByIdAsync(Guid id);
    Task<IEnumerable<Travel>> GetAllAsync();
    Task AddAsync(Travel travel);
    Task UpdateAsync(Travel travel);
    Task DeleteAsync(Guid id);
}