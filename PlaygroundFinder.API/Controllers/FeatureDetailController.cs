using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlaygroundFinder.Models.ViewModels.FeatureDetail;
using PlaygroundFinder.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaygroundFinder.API.Controllers
{   
    /// <summary>
    /// Details of valid options in a Playground Feature
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class FeatureDetailController : ControllerBase
    {

        private readonly IFeatureDetailService _featureDetailService;

        public FeatureDetailController(IFeatureDetailService featureDetailService)
        {
            _featureDetailService = featureDetailService;
        }

        /// <summary>
        /// List of Ground Cover Options available
        /// </summary>
        [HttpGet]
        [Route ("groundCover")]
        public async Task<ActionResult<List<FeatureDetailVM>>> GetAllGroundCover()
        {
            return Ok(await _featureDetailService.GetAllGroundCover());
        }

        /// <summary>
        /// List of AgeRange Options available
        /// </summary>
        [HttpGet]
        [Route("ageRange")]
        public async Task<ActionResult<List<FeatureDetailVM>>> GetAllAgeRange()
        {
            return Ok(await _featureDetailService.GetAllAgeRange());
        }
    }
}
