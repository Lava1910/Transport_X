using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using Transport_X.Interfaces;
using Transport_X.Requests.Order;

namespace Transport_X.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] OrderCreateRequest request)
        {
            var OrderId = await _orderService.Create(request);
            return Ok(OrderId);
        }

        [HttpGet("GetOrderListByUserId/{userId}")]
        public async Task<IActionResult> GetOrderListByUserId(Guid userId)
        {
            var list = await _orderService.GetOrderListByUserId(userId);
            return Ok(list);
        }
    }
}
