using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaygroundFinder.Models.ViewModels.Search
{
    public class SearchCreateVM
    {
        public string AgeRange { get; set; }
        public bool Accessible { get; set; }
        public string Quadrant { get; set; }   
        public string Size { get; set; }

    }
}
