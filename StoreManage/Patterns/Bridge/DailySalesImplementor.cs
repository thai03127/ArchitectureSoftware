namespace StoreManage.Patterns.Bridge
{
    public class DailySalesImplementor : SalesImplementor
    {
        private int saleID;
        private float averagePrice;
        private DateTime startDate;
        private DateTime endDate;


        public DailySalesImplementor(int saleID, float averagePrice, DateTime startDate, DateTime endDate)
        {
            this.saleID = saleID;
            this.averagePrice = averagePrice;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        private float averageSales;

        public void CalculateAverage()
        {
            float totalSales = 5000.0f; // Example total sales
            int numberOfDays = (endDate - startDate).Days;
            averageSales = totalSales / numberOfDays;
        }

        public float GetAverageSales()
        {
            // Return average sales calculated
            return averageSales; // Replace with actual calculation
        }

        public float SetAverageSales(float avg)
        {
            throw new NotImplementedException();
        }
    }

}
