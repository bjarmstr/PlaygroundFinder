using Microsoft.EntityFrameworkCore;
using PlaygroundFinder.Repositories.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Repositories.Repositories
{
    public class FeatureDetailRepository: IFeatureDetailRepository
    {
        private readonly ApplicationDbContext _context;

        public FeatureDetailRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<string>>GetAll(string feature)
        {
            //var results = await _context.PlaygroundGroundCovers
            //    .ToListAsync();
            List<string> results = new() { "DummyData", "RepoNotBuilt", "same answer for all feature requests", feature };
            return results;
        }


    }
}
