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
        /// List of Options available for a given feature
        /// </summary>
        /// <param name="feature"></param>
        /// <remarks>feature GroundCover, AgeRange</remarks>
        [HttpGet("{feature}")]
        public async Task<ActionResult<List<string>>> GetAll(string feature)
        {
            return Ok(await _featureDetailService.GetAll(feature));
        }
    }
}
