using NetTopologySuite.Geometries;
using PlaygroundFinder.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Models.ViewModels.Playground
{

    /// <summary>
    /// Create a playground 
    /// </summary>
    public class PlaygroundCreateVM
    {
       /// <summary>
       /// Playground Names based on City of Calgary Naming Conventions
       /// </summary>
        public string Name { get; set; }

      /// <summary>
      /// GeoLocation Latitude
      /// </summary>
        public double Latitude { get; set; }

        /// <summary>
        /// GeoLocation Longitude
        /// </summary>
        public double Longitude { get; set; }

        /// <summary>
        /// Accessible 
        /// </summary>
        public bool Accessible { get; set; }

        /// <summary>
        /// Quadrant of the city NW, NE, SW, SE
        /// </summary>
        public string Quadrant { get; set; }

        /// <summary>
        /// AgeRange table, id 1 Junior, id 2 Senior
        /// </summary>
        public List<int> AgeRangeIds { get; set; }

        /// <summary>
        /// Ground Cover table, id  1 Natural Round Rock, id 6 Other
        /// </summary>
        public List<int> GroundCoverIds { get; set; }

        /// <summary>
        /// small, medium, large
        /// </summary>
        public string Size { get; set; }

    }
}
