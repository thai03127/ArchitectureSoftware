using Microsoft.AspNetCore.Mvc;
using StoreManage.Models;
using StoreManage.Models.Factory;
using StoreManage.Models.Interface;
using StoreManage.Patterns;
using StoreManage.Patterns.Bridge;
using StoreManage.Patterns.Commands;
using System.Reflection;

namespace StoreManage.Controllers
{
    public class StoreController : Controller
    {
        public IActionResult Index()
        {
            // Lấy thể hiện của Singleton
            Singleton singleton = Singleton.GetInstance();

            // Tạo một số đối tượng Store và thêm vào Singleton
            StoreCreateFactory storeFactory = new StoreCreateFactory();
            singleton.AddStore(storeFactory.CreateStore(1, "Electronic Store", "Electronic Tools", DateTime.Now, DateTime.Now.AddMonths(1), 7856.97, "An Electronic Store is a retail shop specializing in selling a wide range of electronic devices and accessories, including computers, home appliances, entertainment systems and related products.", "https://cellphones.com.vn/"));
            singleton.AddStore(storeFactory.CreateStore(2, "SaiGon Hotel", "Booking hotel", DateTime.Now, DateTime.Now.AddMonths(1), 23456.12, "SaiGon Hotel provides temporary accommodation services for travelers or business guests. Amenities typically include bedrooms, bathrooms, entertainment, and conveniences such as room service.", "https://www.lottehotel.com/global/vi.html"));

            // Lấy danh sách các Store từ Singleton
            List<Store> stores = singleton.GetStores();

            // Create DailySalesImplementor
            SalesImplementor implementor = new DailySalesImplementor(1, 100.0f, DateTime.Now.AddDays(-30), DateTime.Now);

            // Create DailySalesData abstraction
            SalesData salesData = new DailySalesData(implementor);

            // Calculate average sales
            salesData.CalculateAverage();

            // Pass data to partial view
            ViewBag.AverageSales = salesData.GetAverageSales();

            return View(stores);
        }

        public ActionResult OpenWeb(string web)
        {
            // Lấy đối tượng FacadeCMD từ ViewBag
            var facade = new FacadeCMD();
            if (facade != null)
            {
                // Gọi phương thức openWeb từ đối tượng facade
                facade.openWeb(web);
                // Có thể trả về một kết quả nào đó nếu cần thiết
                return Content("openWeb executed successfully.");
            }
            else
            {
                return Content("FacadeCMD object not found in ViewBag.");
            }
        }
    }
}
