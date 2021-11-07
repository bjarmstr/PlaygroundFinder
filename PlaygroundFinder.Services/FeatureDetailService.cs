using PlaygroundFinder.Models.ViewModels.FeatureDetail;
using PlaygroundFinder.Repositories.Repositories.Interfaces;
using PlaygroundFinder.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Services
{
    public class FeatureDetailService: IFeatureDetailService
    {
        private IFeatureDetailRepository _featureDetailRepository;

        public FeatureDetailService(IFeatureDetailRepository featureDetailRepository)
        {
            _featureDetailRepository = featureDetailRepository;
        }
        public async Task<List<FeatureDetailVM>> GetAllGroundCover()
        {

            var results = await _featureDetailRepository.GetAllGroundCover();
            
           var models = results.Select(gc => new FeatureDetailVM { Type = gc.Material, Id = gc.Id }).ToList();

            return models;
        }

        public async Task<List<FeatureDetailVM>> GetAllAgeRange()
        {

            var results = await _featureDetailRepository.GetAllAgeRange();

            var models = results.Select(gc => new FeatureDetailVM { Type = gc.Type, Id = gc.Id }).ToList();

            return models;
        }


    }
}
