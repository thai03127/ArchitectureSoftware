using StoreManage.Models;
using System;

namespace MyMvcApp.Models
{
    public class StoreFactory
    {
        // Phương thức tạo đối tượng Store
        public Store CreateStore(int storeID, string storeName, float price, string productType, DateTime startDate, DateTime endDate, float totalPrice)
        {
            return new Store(storeID, storeName, price, productType, startDate, endDate, totalPrice);
        }
    }
}
