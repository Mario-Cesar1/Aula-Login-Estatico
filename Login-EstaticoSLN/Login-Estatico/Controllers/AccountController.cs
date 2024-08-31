using Microsoft.AspNetCore.Mvc;

namespace Login_Estatico.Controllers
{
    public class AccountController : Controller
    {
        private const string StaticUsername = "admin";
        private const string StaticPassword = "1234";

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string Password)
        {
            if (username == StaticUsername && Password == StaticPassword)
            {
                return RedirectToAction("Index", "Home");
            }
            ViewBag.Error = "Usuário ou senha inválidos!";
            return View();
        }
    }
}
