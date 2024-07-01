namespace StoreManage.Patterns.Bridge
{
    public class DailySalesData : SalesData
    {
        public DailySalesData(SalesImplementor implementor) : base(implementor)
        {
        }

        public override void CalculateAverage()
        {
            implementor.CalculateAverage();
        }

        public override float GetAverageSales()
        {
            return implementor.GetAverageSales();
        }
    }

}
