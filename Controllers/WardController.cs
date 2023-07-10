using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Transport_X.EF;
using Transport_X.Entities;

namespace Transport_X.Controllers
{
    [ApiController]
    [Route("api/wards")]
    public class WardController : ControllerBase
    {
        private readonly TransportXDbContext _context;
        public WardController(TransportXDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var wards = _context.Wards.ToArray();
            return Ok(wards);
        }

        [HttpGet]
        [Route("get-by-id")]
        public IActionResult Get(int WardCode)
        {
            var ward = _context.Wards.Find(WardCode);
            if (ward == null)
                return NotFound();
            return Ok(ward);
        }

        [HttpPost]
        public IActionResult Create(Ward ward)
        {
            _context.Wards.Add(ward);
            _context.SaveChanges();
            return Created($"/get-by-id?id={ward.WardCode}", ward);
        }

        [HttpPut]
        public IActionResult Update(Ward ward)
        {
            _context.Wards.Update(ward);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var wardDelete = _context.Wards.Find(id);
            if (wardDelete == null)
                return NotFound();
            _context.Wards.Remove(wardDelete);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
