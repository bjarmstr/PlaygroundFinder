using NetTopologySuite.Geometries;
using PlaygroundFinder.Models.Entities;
using PlaygroundFinder.Models.ViewModels.FeatureDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Models.ViewModels.Playground
{
    public class PlaygroundVM
    {
        public PlaygroundVM(Entities.Playground src)
        {
            Id = src.Id;
            Name = src.Name;
            // Latitude = src.
            //ongitude 
            Accessible = src.Accessible;
            Quadrant = src.Quadrant;
            //AgeRanges = src.PlaygroundAgeRanges.Select(id => new AgeRangeVM { Id = id.AgeRange.Id, Type = id.AgeRange.Type }).ToList();
            AgeRangeIds = src.PlaygroundAgeRanges.Select(e => e.AgeRange.Id);

            GroundCovers = src.PlaygroundGroundCovers;
            Size = src.Size;

        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        // public Point GeoLocation { get; set; }
       // public double Latitude { get; set }
       // public double Longitude { get; set; }

        public bool Accessible { get; set; }

        public string Quadrant { get; set; }

        public ICollection<AgeRangeVM> AgeRange{ get; set; }
        public IEnumerable<int> AgeRangeIds { get; set; }

        public ICollection<PlaygroundGroundCover> GroundCovers { get; set; }

        public string Size { get; set; }
    }
}
