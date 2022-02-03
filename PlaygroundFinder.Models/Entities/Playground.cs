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
           // GeoLocation = src.GeoLocation;
            Accessible = src.Accessible;
            Quadrant = src.Quadrant;
            PlaygroundAgeRanges = src.AgeRangeIds.Select(id => new PlaygroundAgeRange { AgeRangeId = id }).ToList(); ;
            PlaygroundGroundCovers = src.GroundCoverIds.Select(id => new PlaygroundGroundCover { GroundCoverId = id }).ToList(); ; ;
            Size = src.Size;
            GeoLocation = new Point(src.Longitude, src.Latitude);
           // ListingUploads = src.UploadIds.Select(id => new ListingUpload { UploadId = id }).ToList();


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
        //public Point(double x, double y)

        public string Name { get; set; }

        public bool Accessible { get; set; }

        public string Quadrant { get; set; }
        
        public string Size { get; set; }

        public ICollection<PlaygroundGroundCover> PlaygroundGroundCovers { get; set; }

        public ICollection<PlaygroundAgeRange> PlaygroundAgeRanges{ get; set; }
    }
}
