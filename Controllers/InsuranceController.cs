using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Transport_X.EF;
using Transport_X.Entities;

namespace Transport_X.Controllers
{
    [ApiController]
    [Route("api/insurance")]
    public class InsuranceController : ControllerBase
    {
        private readonly TransportXDbContext _context;
        public InsuranceController(TransportXDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var insurance = _context.Insurance.ToArray();
            return Ok(insurance);
        }

        //[HttpGet]
        //[Route("get-by-id")]
        //public IActionResult Get(int Id)
        //{
        //    var insurance = _context.Insurance.Find(Id);
        //    if (insurance == null)
        //        return NotFound();
        //    return Ok(insurance);
        //}

        //[HttpPost]
        //public IActionResult Create(Insurance insurance)
        //{
        //    _context.Insurance.Add(insurance);
        //    _context.SaveChanges();
        //    return Created($"/get-by-id?id={insurance.Id}", insurance);
        //}

        //[HttpPut]
        //public IActionResult Update(Insurance insurance)
        //{
        //    _context.Insurance.Update(insurance);
        //    _context.SaveChanges();
        //    return NoContent();
        //}

        //[HttpDelete]
        //public IActionResult Delete(int id)
        //{
        //    var insuranceDelete = _context.Insurance.Find(id);
        //    if (insuranceDelete == null)
        //        return NotFound();
        //    _context.Insurance.Remove(insuranceDelete);
        //    _context.SaveChanges();
        //    return NoContent();
        //}
    }
}
