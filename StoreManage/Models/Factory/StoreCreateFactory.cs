using StoreManage.Models.Interface;

namespace StoreManage.Models.Factory
{
    internal class StoreCreateFactory : IStoreFactory
    {
        public Store CreateStore(int storeID, string storeName, string productType, DateTime startDate, DateTime endDate, double TotalPrice, string Description)
        {
            Store store = new Store(storeID, storeName, productType, startDate, endDate, TotalPrice, Description);
            store.CalculateTotalPrice();
            store.ShowInformation();
            return store;
        }
    }
}
