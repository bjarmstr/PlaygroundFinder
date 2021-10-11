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

            // Return the new listing. Entity Framework will have automatically added the new Id value to the entity class.
            return src;
        }

        public async Task<Playground>Get(Guid id)
        {
                var result = await _context.Playgrounds
                .FirstOrDefaultAsync(i => i.Id == id);

            if (result == null) throw new Exception("The requested listing could not be found");
            return result;
        }

    }
}
