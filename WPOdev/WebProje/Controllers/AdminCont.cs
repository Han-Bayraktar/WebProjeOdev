using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebProje.Models;

namespace WebProje.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        private readonly PostgreSqlDbContext _context;

        public AdminController(PostgreSqlDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Management()
        {
            return View();
        }

        // API İşlemleri
        [HttpGet("api/admin/getEmployees")]
        public IActionResult GetEmployees()
        {
            var employees = _context.Employees
                .Select(e => new { e.Id, e.Name, e.Specialty, e.WorkingHours })
                .ToList();

            return Ok(new
            {
                columns = new[] { "Id", "Name", "Specialty", "Working Hours" },
                rows = employees.Select(e => new object[] { e.Id, e.Name, e.Specialty, e.WorkingHours }).ToList()
            });
        }

        [HttpGet("api/admin/getServices")]
        public IActionResult GetServices()
        {
            var services = _context.Services
                .Select(s => new { s.Id, s.Name, s.Price, s.Duration })
                .ToList();

            return Ok(new
            {
                columns = new[] { "Id", "Name", "Price", "Duration" },
                rows = services.Select(s => new object[] { s.Id, s.Name, s.Price, s.Duration }).ToList()
            });
        }

        [HttpPost("api/admin/addEmployee")]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            if (employee == null)
                return BadRequest("Employee data is required");

            _context.Employees.Add(employee);
            _context.SaveChanges();

            return Ok(employee);
        }

        [HttpPut("api/admin/updateEmployee/{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] Employee employee)
        {
            if (employee == null || id != employee.Id)
                return BadRequest("Employee data is invalid");

            _context.Employees.Update(employee);
            _context.SaveChanges();

            return Ok(employee);
        }

        [HttpDelete("api/admin/deleteEmployee/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null)
                return NotFound();

            _context.Employees.Remove(employee);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
