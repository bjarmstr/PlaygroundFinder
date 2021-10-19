using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Repositories.Repositories.Interfaces
{
    public interface IFeatureDetailRepository
    {
        Task<List<string>> GetAll(string feature);
    }
}
