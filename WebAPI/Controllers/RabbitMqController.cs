using Core.Rabbitmq.Abstract;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RabbitMqController : ControllerBase
    {
        readonly IRabbitMqService _rabbitMqService;

        public RabbitMqController(IRabbitMqService rabbitMqService)
        {
            _rabbitMqService = rabbitMqService;
        }


        [HttpPost]
        public IActionResult GetConnection(string uri)
        {
            _rabbitMqService.RabbitMqConneciton(uri);

            return Ok();
        }
    }
}

