namespace StoreManage.Models.Interface
{
    public class Store
    {
        public int StoreID { get; set; }
        public string StoreName { get; set; }
        public string ProductType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double TotalPrice { get; set; }
        public string Description { get; set; } // Add Description property to match JSON

        public Store() { } // Parameterless constructor for deserialization

        public Store(int storeID, string storeName, string productType, DateTime startDate, DateTime endDate, double totalPrice, string description)
        {
            StoreID = storeID;
            StoreName = storeName;
            ProductType = productType;
            StartDate = startDate;
            EndDate = endDate;
            TotalPrice = totalPrice;
            Description = description;
        }

        public void CalculateTotalPrice()
        {
            // Logic để tính toán TotalPrice
            TotalPrice = TotalPrice * (EndDate - StartDate).Days;
        }

        public void ShowInformation()
        {
            Console.WriteLine("Store Information: ID = {0}, Name = {1}, Product Type = {2}, Start Date = {3}, End Date = {4}, Total Price = {5}, Description = {6}",
                StoreID, StoreName, ProductType, StartDate, EndDate, TotalPrice, Description);
        }
    }
}
