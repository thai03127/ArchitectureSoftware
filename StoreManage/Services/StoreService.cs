using Newtonsoft.Json;
using StoreManage.Models.Interface;

namespace StoreManage.Services
{
    public class StoreService
    {
        private List<Store> _stores;

        public StoreService()
        {
            LoadData();
        }

        private void LoadData()
        {
            var jsonData = System.IO.File.ReadAllText("sampleData.json");
            var storeData = Newtonsoft.Json.JsonConvert.DeserializeObject<StoreData>(jsonData);
            _stores = storeData.Stores;
        }

        public List<Store> GetStores()
        {
            return _stores;
        }
    }

    public class StoreData
    {
        public List<Store> Stores { get; set; }
    }
}

