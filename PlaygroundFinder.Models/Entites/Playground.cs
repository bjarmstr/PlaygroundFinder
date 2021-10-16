using NetTopologySuite.Geometries;
using PlaygroundFinder.Models.ViewModels.Playground;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Models.Entities
{
    public class Playground
    {

        public Playground()
        {
        }

        public Playground(PlaygroundCreateVM src)
        {
            Name = src.Name;
            GeoLocation = src.GeoLocation;
            Accessible = src.Accessible;
            Quadrant = src.Quadrant;
            AgeRange = src.AgeRange;
            Size = src.Size;

        }


        //public Playground(PlaygroundUpdateVM src)
        //{
        // Id = src.Id;
        //   Name = src.Name;

        //}

        [Key]
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "geography (point)")]
        public Point GeoLocation { get; set; }

        public string Name { get; set; }

        public bool Accessible { get; set; }

        public string Quadrant { get; set; }

        public string AgeRange { get; set; }
        
        public string Size { get; set; }
    }
}
