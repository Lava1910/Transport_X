using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Transport_X.EF;
using Transport_X.Entities;

namespace Transport_X.Controllers
{
    [ApiController]
    [Route("api/weight")]
    public class WeightController : ControllerBase
    {
        private readonly TransportXDbContext _context;
        public WeightController(TransportXDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var wards = _context.Weight.ToArray();
            return Ok(wards);
        }

        [HttpGet]
        [Route("get-by-id")]
        public IActionResult Get(int Id)
        {
            var weight = _context.Weight.Find(Id);
            if (weight == null)
                return NotFound();
            return Ok(weight);
        }

        [HttpPost]
        public IActionResult Create(Weight weight)
        {
            _context.Weight.Add(weight);
            _context.SaveChanges();
            return Created($"/get-by-id?id={weight.Id}", weight);
        }

        [HttpPut]
        public IActionResult Update(Weight weight)
        {
            _context.Weight.Update(weight);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var weightDelete = _context.Weight.Find(id);
            if (weightDelete == null)
                return NotFound();
            _context.Weight.Remove(weightDelete);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
