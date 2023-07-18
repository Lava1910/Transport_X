using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Transport_X.EF;
using Transport_X.Entities;
using Transport_X.Requests.Order;


namespace Transport_X.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public readonly TransportXDbContext _context;
        public OrderController(TransportXDbContext context)
        {
            _context = context;
        }
        [HttpPost("create")]
        public async Task<IActionResult> Create([FromBody] OrderCreateRequest request)
        {
            var order = _context.Orders.Add(new Order
            {
                SenderName = request.SenderName,
                SenderPhone = request.SenderPhone,
                SenderAddress = request.SenderAddress,
                SenderProvinceId = request.SenderProvinceId,
                SenderDistrictId = request.SenderDistrictId,
                SenderWardId = request.SenderWardId,
                DeliveryDate = DateTime.Now.AddDays(1),
                Note = request.Note,
                Proceeds = request.Proceeds,
                ReceiverName = request.ReceiverName,
                ReceiverPhone = request.ReceiverPhone,
                ReceiverAddress = request.ReceiverAddress,
                ReceiverWardId = request.ReceiverWardId,
                ReceiverDistrictId = request.ReceiverDistrictId,
                ReceiverProvinceId = request.ReceiverProvinceId,
                ReceiveDate = DateTime.Now.AddDays(5),
                GoodsId = request.GoodsId,
                WeightId = request.WeightId,
                InsuranceId = request.InsuranceId,
                StatusId = _context.Status.First().Id,
                UserId = request.UserId
            });
            await _context.SaveChangesAsync();
            return Ok(order);
        }

        [HttpGet("get-by-userId")]
        public IActionResult GetOrderListByUserId(Guid userId)
        {
            var orders =  _context.Orders.Where(e => e.UserId == userId);
            if(orders == null)
            {
                return BadRequest();
            } else
            {
                return Ok(orders);
            }
        }
        
        //public IActionResult SearchOrderByDate(Guid orderId,Date time) { }


       
    }
}
