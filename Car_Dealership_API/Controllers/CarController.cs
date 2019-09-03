using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Car_Dealership_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarApi.Controllers
{
    [Route("api/car")]
    [ApiController]
    public class CarController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        private readonly CarDbContext _context;

        public CarController(CarDbContext context)
        {
            _context = context;

            if (_context.Car.Count() == 0)
            {
                _context.Car.Add(new Car { Make = "Mazda", Model = "CX-5", Year = 2016, Color = "Red" });
                _context.SaveChanges();
            }
        }

        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Car>>> GetCar()
        {
            return await _context.Car.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Car>> GetCar(int id)
        {
            var car = await _context.Car.FindAsync(id);

            if (car == null)
            {
                return NotFound();
            }

            return car;
        }

        // POST: api/Todo
        [HttpPost]
        public async Task<ActionResult<Car>> PostCar(Car newCar)
        {
            _context.Car.Add(newCar);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCar), new { id = newCar.Id }, newCar);
        }

        // PUT: api/Todo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCar(int id, Car car)
        {
            if (id != car.Id)
            {
                return BadRequest();
            }

            _context.Entry(car).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Todo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCar(int id)
        {
            var car = await _context.Car.FindAsync(id);

            if (car == null)
            {
                return NotFound();
            }

            _context.Car.Remove(car);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}

   

