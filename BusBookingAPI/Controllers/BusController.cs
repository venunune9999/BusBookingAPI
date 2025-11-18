using BusBookingAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BusBookingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        public BusController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetBuses()
        {
            var buses = await _dbContext.Buses.ToListAsync();
            return Ok(buses);
        }
        [HttpGet("{busId}/seats")]
        public async Task<IActionResult> GetSeats(int busId)
        {
            var seats = await _dbContext.Seats.Where(s => s.BusId == busId).ToListAsync();
            return Ok(seats);
        }

    }
}
