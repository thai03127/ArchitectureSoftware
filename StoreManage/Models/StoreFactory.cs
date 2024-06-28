using StoreManage.Models;
using System;

namespace MyMvcApp.Models
{
    public class StoreFactory
    {
        // Phương thức tạo đối tượng Store
        public IStore CreateStore(int storeID, string storeName, float price, string productType, DateTime startDate, DateTime endDate)
        {
            return new Store(storeID, storeName, price, productType, startDate, endDate);
        }
    }
}
