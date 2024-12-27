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
                // Kullanıcı bilgilerini al
                var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier); // Kullanıcı ID'sini al

                // Kullanıcı ID'si geçerli mi kontrol et
                if (int.TryParse(userIdString, out int userId))
                {
                    // Eğer randevu zaten alınmışsa, işlem yapılmasın
                    if (appointment.Status)
                    {
                        return Json(new { success = false, message = "Bu randevu zaten alınmış." });
                    }

                    // Randevuyu onayla
                    appointment.Status = true; // Randevuyu onayla (Status'u true yap)
                    appointment.UserId = userId; // Kullanıcı ID'sini randevuya ekle
                    _context.SaveChanges();

                    return Json(new { success = true, message = "Randevunuz başarıyla alındı." });
                }
                else
                {
                    // Hatalı kullanıcı ID'si
                    return Json(new { success = false, message = "Geçersiz kullanıcı." });
                }
            }

            return Json(new { success = false, message = "Randevu bulunamadı." });
        }


        // Randevuyu iptal et
        // Randevuyu iptal et
        [HttpPost]
        public IActionResult CancelAppointment(int appointmentId)
        {
            var appointment = _context.Appointments.Find(appointmentId);

            if (appointment != null)
            {
                // Kullanıcı bilgilerini al
                var userIdString = User.FindFirstValue(ClaimTypes.NameIdentifier); // Kullanıcı ID'sini al

                // Kullanıcı ID'si geçerli mi kontrol et
                if (int.TryParse(userIdString, out int userId))
                {
                    // Randevuyu iptal et sadece o kullanıcının randevusunu
                    if (appointment.UserId == userId)
                    {
                        appointment.Status = false; // Randevuyu iptal et (Status'u false yap)
                        appointment.UserId = 1; // Kullanıcı ID'sini kaldır
                        _context.SaveChanges();

                        return Json(new { success = true, message = "Randevunuz başarıyla iptal edilmiştir." });
                    }
                    else
                    {
                        return Json(new { success = false, message = "Bu randevuyu iptal etme izniniz yok." });
                    }
                }
                else
                {
                    // Hatalı kullanıcı ID'si
                    return Json(new { success = false, message = "Geçersiz kullanıcı." });
                }
            }

            return Json(new { success = false, message = "Randevu bulunamadı." });
        }

    }
}
