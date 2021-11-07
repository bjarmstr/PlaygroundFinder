using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Models.Entities
{
    public class GroundCover
    {
      
        [Key]
        public int Id { get; set; }

        public string Material{ get; set; }

        public ICollection<PlaygroundGroundCover> PlaygroundGroundCovers { get; set; }

    }
}
