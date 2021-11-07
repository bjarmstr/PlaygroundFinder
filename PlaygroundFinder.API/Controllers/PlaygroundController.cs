using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlaygroundFinder.Models.ViewModels.Playground;
using PlaygroundFinder.Models.ViewModels.Search;
using PlaygroundFinder.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaygroundFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaygroundController : ControllerBase
    {
        private readonly IPlaygroundService _playgroundService;

        public PlaygroundController(IPlaygroundService playgroundService)
        {
            _playgroundService = playgroundService;
        }

        /// <summary>
        /// Create new Playground
        /// </summary>
        /// <param name="data"></param>
        [HttpPost]
        public async Task<ActionResult<PlaygroundVM>> Create([FromBody] PlaygroundCreateVM data)
        {
            // Have the service create the new listing
            var result = await _playgroundService.Create(data);

            // Return a 200 response with the ListingVM
            return Ok(result);
        }

        /// <summary>
        /// Get a Playground 
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("{id}")]
        public async Task<ActionResult<PlaygroundVM>>Get ([FromRoute]Guid id)
        {
            
            return Ok(await _playgroundService.Get(id));
        }


        [HttpGet("search")]
        public async Task<ActionResult<List<PlaygroundVM>>> GetBySearchTerms([FromQuery]string accessible, string quadrant, string size, string groundCover)
        {

            var searchVM = new SearchCreateVM ();
            //searchVM.AgeRange = ageRange;
            searchVM.GroundCover = groundCover;
            if (accessible.Contains("true"))
            {
                searchVM.Accessible = true;
            }
            searchVM.Quadrant = quadrant;
            searchVM.Size = size;


            var results = await _playgroundService.GetBySearchTerms(searchVM);
            return Ok(results);
        }

        //[BindProperties]
        //public class SearchCreate
        //{
        //    public string AgeRange { get; set; }
        //    //public bool Accessible { get; set; }
        //    public string Quadrant { get; set; }
        //    public string Size { get; set; }
        //    //public string GroundCover { get; set; }

        //}
    }
}
