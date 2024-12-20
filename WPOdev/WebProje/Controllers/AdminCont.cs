using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebProje.Models; // Add this line if Service class is in Models namespace

namespace WebProje.Controllers
{
    [Authorize(Roles = "admin")]
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ManageServices()
        {
            // Hizmetleri yönetme
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service)
        {
            // Yeni hizmet ekleme
            TempData["Message"] = "Hizmet başarıyla eklendi.";
            return RedirectToAction("ManageServices");
        }

        public IActionResult ManageEmployees()
        {
            // Çalışanları yönetme
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            // Yeni çalışan ekleme
            TempData["Message"] = "Çalışan başarıyla eklendi.";
            return RedirectToAction("ManageEmployees");
        }

        public IActionResult ViewAppointments()
        {
            // Tüm randevuları görme
            return View();
        }
    }
}