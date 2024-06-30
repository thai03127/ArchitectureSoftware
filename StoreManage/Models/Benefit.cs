namespace StoreManage.Models
{
    public class Benefit
    {
        public int benefitID { get; set; }
        public string benefitName { get; set; }
        // Static list to hold benefits
        private static List<Benefit> benefitsList = new List<Benefit>();

        public Benefit() { }

        public Benefit(int benefitID, string benefitName)
        {
            this.benefitID = benefitID;
            this.benefitName = benefitName;
        }
        public void Add()
        {
            // Add the current benefit to the static list
            benefitsList.Add(this);
        }

        public void Remove()
        {
            // Remove the current benefit from the static list
            benefitsList.Remove(this);
        }

        // Optional: Method to get all benefits
        public static List<Benefit> GetAllBenefits()
        {
            return benefitsList;
        }
    }
}
