using System;
using Microsoft.AspNetCore.Mvc;

namespace Order.Api.Controllers
{


    public class OrdersDto
    {
        public string OrerHeader { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }


    [ApiController]
    [Route("api/[controller]/[action]")]
    public class OrderContoller : ControllerBase
    {


        private readonly ILogger<OrderContoller> _logger;

        public OrderContoller(ILogger<OrderContoller> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            var res = new OrdersDto()
            {
                Id = 1,
                Name = "Orer",
                OrerHeader = "dOrder"
            };

            return Ok(res);
        }



        [HttpGet("{id}")]
        public IActionResult GetCategoriesBYId(string id)
        {
            var res = new OrdersDto()
            {
                Id = 2,
                Name = "Orer",
                OrerHeader = "dOrder"
            };

            return Ok(res);
        }




        [HttpPost()]
        public IActionResult CreateCategoriesBYId(OrdersDto input)
        {
            return Ok(input) ;
        }





    }
}

