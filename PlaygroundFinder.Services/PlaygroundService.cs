using PlaygroundFinder.Models.Entities;
using PlaygroundFinder.Models.ViewModels.Playground;
using PlaygroundFinder.Models.ViewModels.Search;
using PlaygroundFinder.Repositories.Repositories.Interfaces;
using PlaygroundFinder.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Services
{
    public class PlaygroundService : IPlaygroundService
    {
        private IPlaygroundRepository _playgroundRepository;

        public PlaygroundService(IPlaygroundRepository playgroundRepository)
        {
            _playgroundRepository = playgroundRepository;
        }

        public async Task<PlaygroundVM> Create(PlaygroundCreateVM src)
        {
            
                // Create the new Playground entity
                var newEntity = new Playground(src);

                // Have the repository create the new listing
                var result = await _playgroundRepository.Create(newEntity);

                // Create the PlaygroundVM we want to return to the client
                var model = new PlaygroundVM(result);

                // Return a PlaygroundVM
                return model;
            
        }

        public async Task<PlaygroundVM>Get(Guid id)
        {
            var result = await _playgroundRepository.Get(id);
            var model = new PlaygroundVM(result);
            return model;
        }

        public async Task<List<PlaygroundVM>> GetBySearchTerms(SearchCreateVM searchTerms)
        {
            var results = await _playgroundRepository.GetBySearchTerms(searchTerms);
            var models = results.Select(i => new PlaygroundVM(i)).ToList();
            return models;
        }


    }
}
