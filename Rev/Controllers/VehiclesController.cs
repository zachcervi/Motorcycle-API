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

            if (!string.IsNullOrEmpty(queryParameters.Make))
            {
                vehicles = vehicles.Where(v => v.Make.ToLower().Contains(queryParameters.Make));
            }

            if (!string.IsNullOrEmpty(queryParameters.Model))
            {
                vehicles = vehicles.Where(v => v.Model.ToLower().Contains(queryParameters.Model));
            }

            if (!string.IsNullOrEmpty(queryParameters.Year))
            {
                vehicles = vehicles.Where(v => v.Year == queryParameters.Year);
            }

            if (!string.IsNullOrEmpty(queryParameters.SortBy))
            {
                if (typeof(Vehicle).GetProperty(queryParameters.SortBy) != null)
                {
                    vehicles = vehicles.OrderByCustom(queryParameters.SortBy, queryParameters.sortOrder);
                }
            }

            vehicles = vehicles
                 .Skip(queryParameters.Size * (queryParameters.Page - 1))
                .Take(queryParameters.Size);

            return Ok(await vehicles.ToArrayAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetVehiclebyID (int id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);
            if(vehicle == null)
            {
                return NotFound();
            }
            return Ok(vehicle);
        }

        [HttpPost]
        public async Task<ActionResult<Vehicle>> AddVehicle([FromBody] Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                "GetVehiclebyID",

                new { id = vehicle.Id }, vehicle
                );
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateVehicle([FromRoute] int id, [FromBody] Vehicle vehicle)
        {
            if(id != vehicle.Id)
            {
                return BadRequest();
            }

            _context.Entry(vehicle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if(_context.Vehicles.Find(id) == null)
                {
                    return NotFound();
                }
                throw;
            }
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Vehicle>> DeleteVehicle([FromRoute] int id)
        {
            var vehicle = await _context.Vehicles.FindAsync(id);
            if(vehicle == null)
            {
                return NotFound();
            }
            _context.Vehicles.Remove(vehicle);
            await _context.SaveChangesAsync();
            return vehicle;
        }
    }
}