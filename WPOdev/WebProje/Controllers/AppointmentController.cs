using Microsoft.AspNetCore.Mvc;
using WebProje.Models;
using System.Linq;

namespace WebProje.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly PostgreSqlDbContext _context;

        public AppointmentController(PostgreSqlDbContext context)
        {
            _context = context;
        }

        // Randevu alma sayfasını render et
        public IActionResult BookAppointment()
        {
            // Kullanılabilir servisleri al
            var services = _context.Services.ToList();
            return View(services);
        }

        // Seçilen servise ait randevu saatlerini al
        public IActionResult GetAvailableAppointments(int serviceId)
        {
            var appointments = _context.Appointments
                .Where(a => a.ServiceId == serviceId && !a.Status) // Status == false olanlar, yani alınmamış randevular
                .OrderBy(a => a.AppointmentTime)
                .ToList();

            return Json(appointments);
        }

        // Randevu al
        [HttpPost]
        public IActionResult BookAppointment(int appointmentId)
        {
            var appointment = _context.Appointments.Find(appointmentId);
            if (appointment != null)
            {
                appointment.Status = true; // Randevuyu onayla (true yap)
                _context.SaveChanges();
            }

            return RedirectToAction("BookAppointment");
        }
    }
}
