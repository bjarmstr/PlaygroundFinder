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
        public async Task<List<string>> GetAll(string feature)
        {

            // var result = await _featureDetailRepository.GetAll(feature);
            List<string> optionList = new() { "DummyData", "RepoNotBuilt", "same answer for all feature requests", feature };


            return optionList;
        }
    }
}
