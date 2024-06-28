using Microsoft.AspNetCore.Mvc;
using StoreManage.Models;
using StoreManage.Services;

namespace StoreManage.Controllers
{
    public class AccountController : Controller
    {
        private readonly JsonFileReaderService _jsonFileReaderService;

        public AccountController(JsonFileReaderService jsonFileReaderService)
        {
            _jsonFileReaderService = jsonFileReaderService;
        }

        public IActionResult Index()
        {
            var accounts = _jsonFileReaderService.GetAccounts();
            return View(accounts);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Xử lý logic đăng nhập
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Xử lý logic đăng ký
                return RedirectToAction("Login");
            }

            return View(model);
        }
    }
}
