using StoreManage.Models;

namespace StoreManage.Patterns.Commands
{
    internal class AddBenefitCommand : ICommand
    {
        private Benefit benefit;
        private List<Benefit> benefits; // Assuming this is where benefits are stored

        public AddBenefitCommand(Benefit benefit, List<Benefit> benefits)
        {
            this.benefit = benefit;
            this.benefits = benefits;
        }

        public void Execute()
        {
            benefits.Add(benefit);
        }
    }
}
