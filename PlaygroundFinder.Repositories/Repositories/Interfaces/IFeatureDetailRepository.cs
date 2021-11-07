using PlaygroundFinder.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Repositories.Repositories.Interfaces
{
    public interface IFeatureDetailRepository
    {
        Task<List<GroundCover>> GetAllGroundCover();
        Task<List<AgeRange>> GetAllAgeRange();
    }
}
