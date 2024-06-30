using Microsoft.AspNetCore.Mvc;
using StoreManage.Models;
using StoreManage.Patterns;
using StoreManage.Services;

namespace StoreManage.Controllers
{
    public class StoreController : Controller
    {
       
        private readonly StoreService _storeService;

        public StoreController(StoreService storeService)
        {
            _storeService = storeService;
        }

        public IActionResult Index()
        {
            var stores = _storeService.GetStores();
            return View(stores);
        }
    }
}
