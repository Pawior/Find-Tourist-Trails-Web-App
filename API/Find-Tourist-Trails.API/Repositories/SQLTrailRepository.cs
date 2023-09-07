using Find_Tourist_Trails.Data;
using Find_Tourist_Trails.Models;
using Microsoft.EntityFrameworkCore;

namespace Find_Tourist_Trails.Repositories
{

    public class SQLTrailRepository : ITrailRepository
    {
        private readonly TrailsDbContext trailsDbContext;

        public SQLTrailRepository(TrailsDbContext trailsDbContext)
        {
            this.trailsDbContext = trailsDbContext;
        }

        public async Task<IEnumerable<Trails>> GetAllAsync(string? filterOn, string? filterQuery)
        {
            //throw new NotImplementedException();
            var trailsQuery = trailsDbContext.Trails.AsQueryable();

            //if ( filterOn != null)
            //{

            //}
            // Lepiej:
            if (!string.IsNullOrWhiteSpace(filterOn) && string.IsNullOrWhiteSpace(filterQuery) == false)
            {
                if (filterOn.Equals("difficulty", StringComparison.OrdinalIgnoreCase))
                {
                    trailsQuery = trailsQuery.Where(trail => trail.Difficulty.Contains(filterQuery));
                }
            }
            return await trailsQuery.ToListAsync();
        }
    }
}
