using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Models.ViewModels.Playground
{
    public class PlaygroundCreateVM
    {
       
    
        public string Name { get; set; }

       // [Required]
       // public Point GeoLocation { get; set; }
      
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        public bool Accessible { get; set; }

        public string Quadrant { get; set; }

        public string AgeRange { get; set; }

        public string Size { get; set; }

    }
}
