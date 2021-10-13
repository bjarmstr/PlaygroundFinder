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

        [Required]
        public Point GeoLocation { get; set; }


    }
}
