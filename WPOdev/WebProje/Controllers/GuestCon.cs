using Microsoft.AspNetCore.Mvc;

namespace WebProje.Controllers
{
    public class GuestController : Controller
    {
        // Misafirler için anasayfa (Hizmetlerin, çalışanların ve genel bilgilerin listelendiği sayfa)
        public IActionResult Index()
        {
            return View();
        }

        // Hizmetleri görüntüleme
        //public IActionResult ViewServices()
        //{
        //    // Veritabanından hizmetleri getir ve View'e aktar
        //    // Örneğin: var services = _dbContext.Services.ToList();
        //   // return View(/services/);
        //}

        // Randevu almak istediğinde giriş yapması gerektiğini belirtir
        public IActionResult BookAppointmentPrompt()
        {
            TempData["Message"] = "Randevu almak için giriş yapmanız gerekmektedir.";
            return RedirectToAction("Login", "Guest");
        }

        // Giriş sayfası (misafir kullanıcıdan müşteri veya admin olmaya geçiş)
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            // Giriş doğrulama işlemi (örneğin veritabanı sorgusu)
            // Eğer geçerli ise, kullanıcı rolüne göre yönlendirme yapılır
            if (email == "admin@example.com" && password == "admin")
            {
                // Admin olarak giriş
                return RedirectToAction("Dashboard", "Admin");
            }
            // else if (/email ve password doğrulanırsa/)
            // {
            //     // Müşteri olarak giriş
            //     return RedirectToAction("Dashboard", "Customer");
            // }
            else
            {
                ViewBag.ErrorMessage = "Geçersiz giriş bilgileri!";
                return View();
            }
        }
    }
}