using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DeliveryAPI.Models;
using System.Net;

namespace DeliveryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryController : ControllerBase
    {

        static readonly List<Delivery> _deliveries = new List<Delivery>();

        // GET: api/Delivery
        [HttpGet(Name = "GetDelivery")]
        public IActionResult Get()
        {
            return Ok(_deliveries);
        }

        // POST: api/Delivery
        [HttpPost(Name = "PostDelivery")]
        public IActionResult Post(Delivery delivery)
        {
            delivery.Id = Guid.NewGuid();
            _deliveries.Add(delivery);

            return Created(string.Empty, delivery);
        }
    }
}
