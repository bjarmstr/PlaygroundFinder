using Microsoft.EntityFrameworkCore;
using PlaygroundFinder.Models.Entities;
using PlaygroundFinder.Models.ViewModels.Search;
using PlaygroundFinder.Repositories.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Repositories.Repositories
{
    public class PlaygroundRepository : IPlaygroundRepository
    {

        private readonly ApplicationDbContext _context;

        public PlaygroundRepository(ApplicationDbContext context)
        {
            _context = context;
        }

       
        public async Task<Playground> Create(Playground src)
        {
          
            _context.Playgrounds.Add(src);         // Perform the add in memory
            await _context.SaveChangesAsync();  // Save the changes to the real database

            // Return the new playground. Entity Framework will have automatically added the new Id value to the entity class.
            return src;
        }

        public async Task<Playground>Get(Guid id)
        {
                var result = await _context.Playgrounds
                .FirstOrDefaultAsync(i => i.Id == id);

            if (result == null) throw new Exception("The requested playground could not be found");
            return result;
        }

        public async Task<List<Playground>> GetBySearchTerms(SearchCreateVM searchTerms)
        {
            var query =  _context.Playgrounds.AsQueryable();
            if (!string.IsNullOrEmpty( searchTerms.Quadrant))
              {
                query = query.Where(playground => playground.Quadrant == searchTerms.Quadrant);
               }
            if (!string.IsNullOrEmpty(searchTerms.Size))
            {
                query = query.Where(playground => playground.Size == searchTerms.Size);
            }
            if (!string.IsNullOrEmpty(searchTerms.GroundCover))
            {
                query = query.Where(playground => playground.PlaygroundGroundCovers.Any(gc => gc.GroundCover.Material == searchTerms.GroundCover));
            }
            if (!string.IsNullOrEmpty(searchTerms.AgeRange))
            {
                query = query.Where(playground => playground.PlaygroundAgeRanges.Any(ag => ag.AgeRange.Type == searchTerms.AgeRange));
            }
            if (searchTerms.Accessible.HasValue)
            {
                query = query.Where(playground => playground.Accessible == searchTerms.Accessible);
            }


                //query = query.Where(playground =>
                //       playground.Quadrant == searchTerms.Quadrant &&
                //      playground.Size == searchTerms.Size && 
                //      playground.PlaygroundGroundCovers.Any(gc => gc.GroundCover.Material == searchTerms.GroundCover)
                //      )
                query = query.Include(e => e.PlaygroundAgeRanges).ThenInclude(e => e.AgeRange);

            query = query.Include(playground => playground.PlaygroundGroundCovers).ThenInclude(e => e.GroundCover);
            
            var results = await query.ToListAsync();


            return results;

            //            var results = context.Members;
            //            if (vm.Active.HasValue)
            //            {
            //                results = results.Where(x => x.Active == vm.Active.Value);
            //            }
            //            if (!string.IsNullOrEmpty vm.FirstName))
            //{
            //                results = results.Where(x => x.FirstName == vm.FirstName);
            //            }
            //            return results.ToList();

        }


    }
}
