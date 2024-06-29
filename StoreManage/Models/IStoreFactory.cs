using StoreManage.Models;
using System;

namespace StoreManage.Models
{
    public interface IStoreFactory
    {
        // Phương thức tạo đối tượng Store
        IStore CreateStore(int storeID, string storeName, string productType, DateTime startDate, DateTime endDate);
    }
}
