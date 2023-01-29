using System;
using Microsoft.AspNetCore.Mvc;

namespace catalog.Api.Controllers
{

    public class CateGoriesDto 
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }


    [ApiController]
    [Route("[controller]")]
    public class CategoriContoller : ControllerBase
    {

        private readonly ILogger<CategoriContoller> _logger;

        public CategoriContoller(ILogger<CategoriContoller> logger)
        {
            _logger = logger;
        }



        [HttpGet]
        public IActionResult GetCategories()
        {
            var res = new CateGoriesDto()
            {
                Id = 1,
                Name = "Categori"
            };

            return Ok(res);
        }
    }
}

