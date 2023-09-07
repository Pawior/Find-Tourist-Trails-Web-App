using Find_Tourist_Trails.Models;

namespace Find_Tourist_Trails.Repositories
{
    public interface ITrailRepository
    {

        Task<IEnumerable<Trails>> GetAllAsync(string? filterOn, string? filterQuery);   
    }
}
