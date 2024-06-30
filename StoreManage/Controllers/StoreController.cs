using Microsoft.AspNetCore.Mvc;
using StoreManage.Models;
using StoreManage.Models.Factory;
using StoreManage.Models.Interface;
using StoreManage.Patterns;
using StoreManage.Services;

namespace StoreManage.Controllers
{
    public class StoreController : Controller
    {
        //private readonly StoreService _storeService;

        //public StoreController(StoreService storeService)
        //{
        //    _storeService = storeService;
        //}

        public IActionResult Index()
        {
            // Lấy thể hiện của Singleton
            Singleton singleton = Singleton.GetInstance();

            // Tạo một số đối tượng Store và thêm vào Singleton
            StoreCreateFactory storeFactory = new StoreCreateFactory();
            singleton.AddStore(storeFactory.CreateStore(1, "Electronic Store", "Electronic Tools", DateTime.Now, DateTime.Now.AddMonths(1), 7856.97, "An Electronic Store is a retail shop specializing in selling a wide range of electronic devices and accessories, including computers, home appliances, entertainment systems and related products."));
            singleton.AddStore(storeFactory.CreateStore(2, "SaiGon Hotel", "Booking hotel", DateTime.Now, DateTime.Now.AddMonths(1), 23456.12, "SaiGon Hotel provides temporary accommodation services for travelers or business guests. Amenities typically include bedrooms, bathrooms, entertainment, and conveniences such as room service."));

            // Lấy danh sách các Store từ Singleton
            List<Store> stores = singleton.GetStores();
            return View(stores);
        }
    }
}
