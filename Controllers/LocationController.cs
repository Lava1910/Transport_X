using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Transport_X.EF;
using Transport_X.Entities;

namespace Transport_X.Controllers
{
    [ApiController]
    [Route("api/location")]
    public class LocationController : Controller
    {
        private readonly TransportXDbContext _context;
        public LocationController(TransportXDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("get-province")]
        public IActionResult GetProvince()
        {
            var provinces = _context.Provinces.ToArray();
            return Ok(provinces);
        }

        [HttpGet]
        [Route("get-district")]
        public IActionResult GetDistrictFromProvince(int Id)
        {
            var districts = _context.Districts.Where(e => e.ProvinceId == Id);
            return Ok(districts);
        }

        [HttpGet]
        [Route("get-ward")]
        public IActionResult GetWardFromDistrict(int Id)
        {
            var wards = _context.Wards.Where(e => e.DistrictId == Id);
            return Ok(wards);
        }
    }
}
