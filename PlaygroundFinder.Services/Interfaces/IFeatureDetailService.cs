using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Services.Interfaces
{
    public interface IFeatureDetailService
    {
        Task<List<string>> GetAll(string feature);


    }
}
