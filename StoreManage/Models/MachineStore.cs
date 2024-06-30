
namespace StoreManage.Models
{
    public class MachineStore : IStoreFactory
    {
        public IStore CreateStore(int storeID, string storeName, string productType, DateTime startDate, DateTime endDate)
        {
            Store store = new Store(storeID, storeName, productType, startDate, endDate, 1112, "");
            return store;
        }
    }
}
