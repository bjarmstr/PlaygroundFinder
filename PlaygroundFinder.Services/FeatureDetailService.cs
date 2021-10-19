using PlaygroundFinder.Models.ViewModels.FeatureDetail;
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
        public async Task<List<FeatureDetailVM>> GetAllGroundCover()
        {

            // var result = await _featureDetailRepository.GetAll(feature);
            FeatureDetailVM groundCover1 = new();
            groundCover1.Id = 1;
            groundCover1.Type = "test data No Repo";
            List<FeatureDetailVM> results = new();
            results.Add(groundCover1);

            return results;
        }

        public async Task<List<FeatureDetailVM>> GetAllAgeRange()
        {

            // var result = await _featureDetailRepository.GetAll(feature);
            FeatureDetailVM groundCover1 = new();
            groundCover1.Id = 1;
            groundCover1.Type = "test data No Repo";
            List<FeatureDetailVM> results = new();
            results.Add(groundCover1);

            return results;
        }


    }
}
