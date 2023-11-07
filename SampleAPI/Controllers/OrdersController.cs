using Microsoft.AspNetCore.Mvc;
using SampleAPI.Entities;
using SampleAPI.Repositories;
using SampleAPI.Requests;

namespace SampleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        // Add more dependencies as needed.

        public OrdersController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
 
        [HttpGet("GetOrders")] // TODO: Change route, if needed.
        [ProducesResponseType(StatusCodes.Status200OK)] // TODO: Add all response types
        public async Task<ActionResult<List<Order>>> GetOrders()
        {
          return   _orderRepository.GetOrderList();
        }


        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)] // TODO: Add all response types
        public async Task AddUpdateOrder(Order order)
        {
            _orderRepository.AddNewOrder(order);
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)] // TODO: Add all response types
        public async Task RemoveOrder(int orderId)
        {
            _orderRepository.RemoveOrder(orderId);
        }

        /// TODO: Add an endpoint to allow users to create an order using <see cref="CreateOrderRequest"/>.
    }
}
