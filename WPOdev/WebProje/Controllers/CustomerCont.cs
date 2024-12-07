using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Dashboard()
        {
            // Müşterinin ana sayfası
            return View();
        }

        public IActionResult BookAppointment()
        {
            // Randevu alma sayfası
            return View();
        }

        [HttpPost]
        public IActionResult BookAppointment(int serviceId, int employeeId, DateTime time)
        {
            // Randevuyu kaydetme işlemi
            TempData["Message"] = "Randevunuz başarıyla alındı.";
            return RedirectToAction("Dashboard");
        }
    }
}