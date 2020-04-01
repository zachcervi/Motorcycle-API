using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rev.Classes;
using Rev.Models;

namespace Rev.Controllers
{
    [Route("vehicles")]
    [ApiController]
    public class VehiclesController : Controller
    {
        private readonly VehicleContext _context;

        public VehiclesController(VehicleContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }
       
        [HttpGet]
        public async Task<IActionResult> GetAllVehicles([FromQuery] VehicleQueryParameters queryParameters)
        {
            IQueryable<Vehicle> vehicles = _context.Vehicles;
            return Ok(await vehicles.ToArrayAsync());
        }
    }
}