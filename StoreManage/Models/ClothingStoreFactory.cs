using MyMvcApp.Models;
using StoreManage.Models;
using System;

namespace StoreManage.Models
{
    public class ClothingStoreFactory : IStoreFactory
    {
        // Phương thức triển khai để tạo đối tượng Store
        public IStore CreateStore(int storeID, string storeName, float price, string productType, DateTime startDate, DateTime endDate)
        {
            return new Store(storeID, storeName, price, productType, startDate, endDate);
        }
    }
}
