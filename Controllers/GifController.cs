using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.Extensions.Configuration;
using catGifs.Services;

namespace catGif.Controllers
{
    [ApiVersion("0.1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class GifController : Controller
    {
        public IConfiguration Configuration { get; set; }
        public IImgService ImgService { get; set; }

        public GifController(IConfiguration configuration, IImgService imgService)
        {
            this.Configuration = configuration;
            this.ImgService = imgService;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await this.ImgService.GetRandomImage();
            return Ok(result);
        }

        // GET api/values/5
        [HttpGet("{tags}")]
        public async Task<IActionResult> Get([FromRoute] string tags)
        {
            var result = await this.ImgService.GetRandomImage(tags);
            return Ok(result);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
