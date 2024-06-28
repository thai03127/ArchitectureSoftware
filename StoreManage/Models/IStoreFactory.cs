using StoreManage.Models;
using System;

namespace MyMvcApp.Models
{
    public interface IStoreFactory
    {
        // Phương thức tạo đối tượng Store
        IStore CreateStore(int storeID, string storeName, float price, string productType, DateTime startDate, DateTime endDate);
    }
}
