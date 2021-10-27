using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlaygroundFinder.Models.ViewModels.Upload;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaygroundFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadController : ControllerBase
    {


        [HttpPost]
        public async Task<ActionResult<List<UploadResultVM>>> UploadImage()
        {
            // Validate the file types
            var supportedTypes = new[] { ".png", ".gif", ".jpg", ".jpeg" };
            var uploadedExtensions = Request.Form.Files.Select(i => System.IO.Path.GetExtension(i.FileName));
            var mismatchFound = uploadedExtensions.Any(i => !supportedTypes.Contains(i));
            if (mismatchFound)
                return BadRequest(new { message = "At least one uploaded file is not a valid image type" });


            var results = new List<UploadResultVM>();
            foreach (var file in Request.Form.Files)
            {
                results.Add(new UploadResultVM
                {
                    FileName = file.FileName
                });

            }
                //var results = await _uploadService.UploadFiles(Request.Form.Files.ToList());
                return Ok(results);
           

        }
    }
}
