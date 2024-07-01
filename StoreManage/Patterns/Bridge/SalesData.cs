namespace StoreManage.Patterns.Bridge
{
    public abstract class SalesData
    {
        protected SalesImplementor implementor;

        public SalesData(SalesImplementor implementor)
        {
            this.implementor = implementor;
        }

        public abstract void CalculateAverage();
        public abstract float GetAverageSales();
    }

}
