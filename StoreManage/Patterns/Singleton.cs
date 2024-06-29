namespace StoreManage.Patterns
{
    internal class Singleton
    {
        public string storeName { get; set; }
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
        public void showInformation(string mesg)
        {
            Console.WriteLine("SingleTon {0} - {1}", storeName, mesg);
        }

    }
}
