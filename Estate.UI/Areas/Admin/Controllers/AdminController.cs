using EntityLayer.Entities;
using Estate.UI.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.DataProtection;

namespace Estate.UI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        
        private readonly UserManager <UserAdmin> _userManager;
        private readonly  SignInManager <UserAdmin> _signInManager;
        // Şifreleme için DataProtectionProvider ekleme
        private readonly IDataProtectionProvider _dataProtectionProvider;

        public AdminController(UserManager<UserAdmin> userManager, SignInManager<UserAdmin> signInManager, IDataProtectionProvider dataProtectionProvider)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _dataProtectionProvider = dataProtectionProvider;
        }

        public IActionResult Index()
        {
            // Tüm kullanıcıları al
            var allUsers = _userManager.Users.ToList();

            return View(allUsers);
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View(new LoginModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userManager.FindByNameAsync(model.Username);
            if (user == null)
            {
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı.");
            }

            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);

            if (result.Succeeded)
            {
                // Kullanıcı bilgilerini şifreleyerek session'a ekleme
                var protector = _dataProtectionProvider.CreateProtector("Estate.UI.AdminController");
                var encryptedId = protector.Protect(user.Id);
                HttpContext.Session.SetString("Id", encryptedId);
                HttpContext.Session.SetString("FullName", user.FullName);

                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
