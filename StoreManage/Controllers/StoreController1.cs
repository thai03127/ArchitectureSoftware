using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;
using StoreManage.Models;

namespace StoreManage.Controllers
{
    public class StoreController1 : Controller
    {
        public IActionResult Index()
        {
            // Tạo instance của StoreFactory
            StoreFactory storeFactory = new StoreFactory();

            // Tạo đối tượng Store bằng cách sử dụng StoreFactory
            Store store = storeFactory.CreateStore(1, "Sample Store", 100.0f, "Electronics", DateTime.Now, DateTime.Now.AddMonths(1), 1200.0f);

            // Hiển thị thông tin của cửa hàng
            store.ShowInformation();

            // Trả về view cùng với đối tượng Store
            return View(store);
        }
    }
}
