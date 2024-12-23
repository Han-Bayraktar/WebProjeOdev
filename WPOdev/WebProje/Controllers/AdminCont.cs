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

        // CRUD İşlemleri: Employees
        [HttpGet("api/admin/getEmployees")]
        public IActionResult GetEmployees()
        {
            var employees = _context.Employees
                .Select(e => new { e.Id, e.Name, e.Specialty, e.WorkingHours })
                .ToList();

            return Ok(employees);
        }

        [HttpPost("api/admin/addEmployees")]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            if (employee == null)
                return BadRequest("Employee data is required");

            _context.Employees.Add(employee);
            _context.SaveChanges();

            return Ok(employee);
        }

        [HttpPut("api/admin/updateEmployees/{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] Employee employee)
        {
            if (employee == null || id != employee.Id)
                return BadRequest("Employee data is invalid");

            _context.Employees.Update(employee);
            _context.SaveChanges();

            return Ok(employee);
        }

        [HttpDelete("api/admin/deleteEmployees/{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee == null)
                return NotFound();

            _context.Employees.Remove(employee);
            _context.SaveChanges();

            return NoContent();
        }

        // CRUD İşlemleri: Services
        [HttpGet("api/admin/getServices")]
        public IActionResult GetServices()
        {
            var services = _context.Services
                .Select(s => new { s.Id, s.Name, s.Price, s.Duration })
                .ToList();

            return Ok(services);
        }

        [HttpPost("api/admin/addServices")]
        public IActionResult AddService([FromBody] Service service)
        {
            if (service == null)
                return BadRequest("Service data is required");

            _context.Services.Add(service);
            _context.SaveChanges();

            return Ok(service);
        }

        [HttpPut("api/admin/updateServices/{id}")]
        public IActionResult UpdateService(int id, [FromBody] Service service)
        {
            if (service == null || id != service.Id)
                return BadRequest("Service data is invalid");

            _context.Services.Update(service);
            _context.SaveChanges();

            return Ok(service);
        }

        [HttpDelete("api/admin/deleteServices/{id}")]
        public IActionResult DeleteService(int id)
        {
            var service = _context.Services.Find(id);
            if (service == null)
                return NotFound();

            _context.Services.Remove(service);
            _context.SaveChanges();

            return NoContent();
        }

        // CRUD İşlemleri: Users
        [HttpGet("api/admin/getUsers")]
        public IActionResult GetUsers()
        {
            var users = _context.Users
                .Select(u => new { u.Id, u.Name, u.Surname, u.Email, u.Role })
                .ToList();

            return Ok(users);
        }

        [HttpPost("api/admin/addUsers")]
        public IActionResult AddUser([FromBody] User user)
        {
            if (user == null)
                return BadRequest("User data is required");

            _context.Users.Add(user);
            _context.SaveChanges();

            return Ok(user);
        }

        [HttpPut("api/admin/updateUsers/{id}")]
        public IActionResult UpdateUser(int id, [FromBody] User user)
        {
            if (user == null || id != user.Id)
                return BadRequest("User data is invalid");

            _context.Users.Update(user);
            _context.SaveChanges();

            return Ok(user);
        }

        [HttpDelete("api/admin/deleteUsers/{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user == null)
                return NotFound();

            _context.Users.Remove(user);
            _context.SaveChanges();

            return NoContent();
        }

        // CRUD İşlemleri: Appointments
        [HttpGet("api/admin/getAppointments")]
        public IActionResult GetAppointments()
        {
            var appointments = _context.Appointments
                .Include(a => a.User)
                .Include(a => a.Service)
                .Include(a => a.Employee)
                .Select(a => new
                {
                    a.Id,
                    UserName = a.User.Name,
                    ServiceName = a.Service.Name,
                    EmployeeName = a.Employee.Name,
                    a.AppointmentTime,
                    a.Status
                })
                .ToList();

            return Ok(appointments);
        }

        [HttpPost("api/admin/addAppointments")]
        public IActionResult AddAppointment([FromBody] Appointment appointment)
        {
            if (appointment == null)
                return BadRequest("Appointment data is required");

            _context.Appointments.Add(appointment);
            _context.SaveChanges();

            return Ok(appointment);
        }

        [HttpPut("api/admin/updateAppointments/{id}")]
        public IActionResult UpdateAppointment(int id, [FromBody] Appointment appointment)
        {
            if (appointment == null || id != appointment.Id)
                return BadRequest("Appointment data is invalid");

            _context.Appointments.Update(appointment);
            _context.SaveChanges();

            return Ok(appointment);
        }

        [HttpDelete("api/admin/deleteAppointments/{id}")]
        public IActionResult DeleteAppointment(int id)
        {
            var appointment = _context.Appointments.Find(id);
            if (appointment == null)
                return NotFound();

            _context.Appointments.Remove(appointment);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
