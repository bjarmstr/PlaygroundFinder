using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Models.Entities
{
    public class PlaygroundGroundCover
    {
        public Guid PlaygroundId { get; set; }
        public Guid GroundCoverId { get; set; }
    }
}
