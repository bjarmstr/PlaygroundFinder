using PlaygroundFinder.Models.ViewModels.Playground;
using PlaygroundFinder.Models.ViewModels.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Services.Interfaces
{
    public interface IPlaygroundService
    {
        Task<PlaygroundVM> Create(PlaygroundCreateVM src);
        Task<PlaygroundVM> Get(Guid id);
        Task<List<PlaygroundVM>> GetBySearchTerms(SearchCreateVM searchTerms);


    }
}
