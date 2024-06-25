using Microsoft.AspNetCore.Mvc;
using StoreManage.Models;

namespace StoreManage.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            var account = Account.GetInstance();
            account.AccID = 1;
            account.AccName = "John Doe";
            account.Email = "john.doe@example.com";
            account.Permission = 1;
            account.Status = 1;
            return View(account);
        }
    }
}
