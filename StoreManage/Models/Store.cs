namespace StoreManage.Models
{
    public class Store : IStore
    {
        public int StoreID { get; set; }
        public string StoreName { get; set; }
        public float Price { get; set; }
        public string ProductType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float TotalPrice { get; set; }

        public Store(int storeID, string storeName, float price, string productType, DateTime startDate, DateTime endDate)
        {
            StoreID = storeID;
            StoreName = storeName;
            Price = price;
            ProductType = productType;
            StartDate = startDate;
            EndDate = endDate;
        }

        public void CalculateTotalPrice()
        {
            // Logic để tính toán TotalPrice
            TotalPrice = Price * (EndDate - StartDate).Days;
        }

        public void ShowInformation()
        {
            Console.WriteLine("Store Information: ID = {0}, Name = {1}, Price = {2}, Product Type = {3}, Start Date = {4}, End Date = {5}, Total Price = {6}",
                StoreID, StoreName, Price, ProductType, StartDate, EndDate, TotalPrice);
        }
    }
}
