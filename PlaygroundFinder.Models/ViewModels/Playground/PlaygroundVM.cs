using NetTopologySuite.Geometries;
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
         
        }

        public Guid Id { get; set; }
    
        public string Name { get; set; }

        public Point GeoLocation { get; set; }
    }
}
