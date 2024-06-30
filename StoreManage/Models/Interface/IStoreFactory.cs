using System;

namespace StoreManage.Models.Interface
{
    public interface IStoreFactory
    {
        // Phương thức tạo đối tượng Store
        Store CreateStore(int storeID, string storeName, string productType, DateTime startDate, DateTime endDate, double TotalPrice, string Description);
    }
}
