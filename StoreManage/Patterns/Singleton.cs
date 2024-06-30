using StoreManage.Models;

namespace StoreManage.Patterns
{
    internal class Singleton
    {
        public string storeName { get; set; }
        public string storeDes { get; set; }
        public string sale { get; set; }

        private Singleton() { }

        private static Singleton _instance;

        public static Singleton getInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
        public Store showInformation(Store store)
        {
            MachineStore machineStore = new MachineStore();
            return machineStore.CreateStore(store);
        }

    }
}
