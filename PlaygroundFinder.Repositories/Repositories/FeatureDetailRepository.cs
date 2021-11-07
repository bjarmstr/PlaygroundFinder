using Microsoft.EntityFrameworkCore;
using PlaygroundFinder.Models.Entities;
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

        public async Task<List<GroundCover>>GetAllGroundCover()
        {
            var results = await _context.GroundCovers
                .ToListAsync();
            return results;
        }


        public async Task<List<AgeRange>> GetAllAgeRange()
        {
            var results = await _context.AgeRanges
               .ToListAsync();
            return results;
        }


    }
}
