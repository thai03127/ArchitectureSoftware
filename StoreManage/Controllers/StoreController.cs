using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Models;
using StoreManage.Models;
using StoreManage.Services;

namespace StoreManage.Controllers
{
    public class StoreController : Controller
    {
        private readonly JsonFileReaderService _jsonFileReaderService;
        private readonly IStoreFactory _storeFactory;

        public StoreController(JsonFileReaderService jsonFileReaderService)
        {
            _jsonFileReaderService = jsonFileReaderService;
            _storeFactory = new IStoreFactory();
        }

        public IActionResult Index()
        {
            // Lấy dữ liệu từ tệp JSON
            var stores = _jsonFileReaderService.GetStores();

            // Tính toán tổng giá cho mỗi cửa hàng
            foreach (var store in stores)
            {
                store.CalculateTotalPrice();
                store.ShowInformation();
            }

            // Trả về view cùng với danh sách các cửa hàng
            return View(stores);
        }
    }
}
