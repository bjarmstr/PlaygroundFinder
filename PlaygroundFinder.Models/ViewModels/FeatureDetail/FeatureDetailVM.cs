using PlaygroundFinder.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Models.ViewModels.FeatureDetail
{
    public class FeatureDetailVM
    {

        public FeatureDetailVM()
        {

        }

        public FeatureDetailVM(GroundCover src)
        {
            Id = src.Id;
            Type= src.Material;
        }

        public FeatureDetailVM(AgeRange src)
        {
            Id = src.Id;
            Type = src.Type;
        }

        public int Id { get; set; }

        public string Type { get; set; }

    }
}
