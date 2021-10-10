using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlaygroundFinder.Models.Entities;
using PlaygroundFinder.Repositories.Repositories.Interfaces;
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
        private readonly IPlaygroundRepository _listingService;

        public PlaygroundController(IPlaygroundRepository listingService)
        {
            _listingService = listingService;
        }

        // Create a new listing
        [HttpPost]
        public async Task<ActionResult<Playground>> Create([FromBody] Playground data)
        {
            // Have the service create the new listing
            var result = await _listingService.Create(data);

            // Return a 200 response with the ListingVM
            return Ok(result);
        }
    }
}
