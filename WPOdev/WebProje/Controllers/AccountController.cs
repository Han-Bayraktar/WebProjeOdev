using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WebProje.Models;
using System.Security.Claims;

namespace WebProje.Controllers
{
    public class AccountController : Controller
    {
        private readonly PostgreSqlDbContext _context;

        public AccountController(PostgreSqlDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            var existingUser = _context.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);

            if (existingUser == null)
            {
                ModelState.AddModelError("", "Invalid email or password.");
                return View();
            }

            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, existingUser.Name),
        new Claim(ClaimTypes.Email, existingUser.Email),
        new Claim(ClaimTypes.Role, existingUser.Role),
    };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            // Role-based redirect
            if (existingUser.Role == "admin")
            {
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return RedirectToAction("Index", "Home"); // Müşteri için ana sayfa
            }
        }

        [Authorize(Roles = "admin")]
        public IActionResult AccessDenied()
        {
            return View();
        }

        [Authorize]
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string name, string surname, string email, string password)
        {
            if (!ModelState.IsValid)
            {
                // Doğrulama hatalarını kontrol edin
                return View();
            }

            if (_context.Users.Any(u => u.Email == email))
            {
                ModelState.AddModelError("", "Email is already registered.");
                return View();
            }

            var user = new User
            {
                Name = name,
                Surname = surname,
                Email = email,
                Password = password,
                Role = "customer"
            };

            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToAction("Login");
        }
        
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home"); // Giriş sayfasına yönlendir
        }



    }


}

