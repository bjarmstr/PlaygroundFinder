using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Models.ViewModels.FeatureDetail
{
    public class AgeRangeVM
    {
            public AgeRangeVM() { }

            public AgeRangeVM(Entities.AgeRange src)
            {
                Id = src.Id;
                Type = src.Type;
            }
            public int Id { get; set; }
            public string Type{ get; set; }
    }
}