using Microsoft.AspNetCore.Mvc;
using Transport_X.EF;

namespace Transport_X.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        public readonly TransportXDbContext _context;
        public StatusController(TransportXDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public string GetStatusName(Guid orderId)
        {
            var order = _context.Orders.First(x => x.OrderId == orderId);
            var status = _context.Status.First(x => x.Id == order.StatusId);
            if (status != null)
            {
                return status.Description;
            } else
            {
                return "";
            }
        }
    }
}
