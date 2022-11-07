using DeliveryAPI.Controllers;
using DeliveryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeliveryAPI.Tests
{
    public class DeliveryControllerTest
    {
        private readonly DeliveryController _controller;

        public DeliveryControllerTest()
        {
            _controller = new DeliveryController();
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            var okResult = _controller.Get();

            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact]
        public void Add_ValidObjectPassed_ReturnsCreatedResponse()
        {
            Delivery testDelivery = new Delivery()
            {
                DeliveryNumber = 1024,
                DeliveryDate = DateTime.Now
            };

            var createdResponse = _controller.Post(testDelivery);

            Assert.IsType<CreatedResult>(createdResponse);
        }

        [Fact]
        public void Add_ValidObjectPassed_ReturnedResponseHasCreatedDelivery()
        {
            var testDelivery = new Delivery()
            {
                DeliveryNumber = 1024,
                DeliveryDate = DateTime.Now
            };

            var createdResponse = _controller.Post(testDelivery) as CreatedResult;
            var item = createdResponse.Value as Delivery;

            Assert.IsType<Delivery>(item);
            Assert.Equal(1024, item.DeliveryNumber);
        }
    }
}