using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Transport_X.EF;
using Transport_X.Entities;

namespace Transport_X.Controllers
{
    [ApiController]
    [Route("api/goods")]
    public class GoodsController : ControllerBase
    {
        private readonly TransportXDbContext _context;
        public GoodsController(TransportXDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var goods = _context.Goods.ToArray();
            return Ok(goods);
        }

        [HttpGet]
        [Route("get-by-id")]
        public IActionResult Get(int Id)
        {
            var goods = _context.Goods.Find(Id);
            if (goods == null)
                return NotFound();
            return Ok(goods);
        }

        [HttpPost]
        public IActionResult Create(Goods goods)
        {
            _context.Goods.Add(goods);
            _context.SaveChanges();
            return Created($"/get-by-id?id={goods.Id}", goods);
        }

        [HttpPut]
        public IActionResult Update(Goods goods)
        {
            _context.Goods.Update(goods);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var gooodsDelete = _context.Goods.Find(id);
            if (gooodsDelete == null)
                return NotFound();
            _context.Goods.Remove(gooodsDelete);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
