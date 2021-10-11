using PlaygroundFinder.Models.ViewModels.Playground;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        }


        //public Playground(PlaygroundUpdateVM src)
        //{
        // Id = src.Id;
        //   Name = src.Name;

        //}

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
