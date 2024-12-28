using Microsoft.AspNetCore.Mvc;
using WebProje.Models;
using System.Linq;
using System.Security.Claims;

namespace WebProje.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly PostgreSqlDbContext _context;

        public AppointmentController(PostgreSqlDbContext context)
        {
            _context = context;
        }

        public IActionResult BookAppointment()
        {
            var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (int.TryParse(userIdString, out int userId))
            {
                ViewBag.UserId = userId;
            }
            else
            {
                ViewBag.UserId = null;
            }

            var services = _context.Services.ToList(); 
            return View(services);
        }

        public IActionResult GetAvailableAppointments(int serviceId)
        {
            var appointments = _context.Appointments
                .Where(a => a.ServiceId == serviceId)
                .OrderBy(a => a.AppointmentTime)
                .Select(a => new
                {
                    a.Id,
                    a.AppointmentTime,
                    a.Status,
                    a.UserId
                })
                .ToList();

            return Json(appointments);
        }

        [HttpPost]
        public IActionResult BookAppointment(int appointmentId)
        {
            var appointment = _context.Appointments.Find(appointmentId);

            if (appointment != null)
            {
                var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (!string.IsNullOrEmpty(userIdString) && int.TryParse(userIdString, out int userId))
                {
                    if (appointment.Status)
                    {
                        return Json(new { success = false, message = "Bu randevu zaten alınmış." });
                    }

                    appointment.Status = true;
                    appointment.UserId = userId;
                    _context.SaveChanges();

                    return Json(new { success = true, message = "Randevunuz başarıyla alındı." });
                }

                return Json(new { success = false, message = "Randevu Almak için giriş yapmalısınız !!" });
            }

            return Json(new { success = false, message = "Randevu bulunamadı." });
        }


        [HttpPost]
        public IActionResult CancelAppointment(int appointmentId)
        {
            var appointment = _context.Appointments.Find(appointmentId);

            if (appointment != null)
            {
                var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (!string.IsNullOrEmpty(userIdString) && int.TryParse(userIdString, out int userId))
                {
                    if (appointment.UserId == userId)
                    {
                        appointment.Status = false;
                        appointment.UserId = 1; 
                        _context.SaveChanges();

                        return Json(new { success = true, message = "Randevunuz başarıyla iptal edildi." });
                    }

                    return Json(new { success = false, message = "Bu randevuyu iptal etme izniniz yok." });
                }

                return Json(new { success = false, message = "Geçersiz kullanıcı." });
            }

            return Json(new { success = false, message = "Randevu bulunamadı." });
        }

    }
}
