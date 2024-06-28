namespace StoreManage.Models
{
    public interface IStore
    {
        int StoreID { get; set; }
        string StoreName { get; set; }
        float Price { get; set; }
        string ProductType { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        float TotalPrice { get; set; }

        void CalculateTotalPrice();
    }
}
