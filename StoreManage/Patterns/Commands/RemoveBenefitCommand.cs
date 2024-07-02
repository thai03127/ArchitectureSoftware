using StoreManage.Models;

namespace StoreManage.Patterns.Commands
{
    public class RemoveBenefitCommand : ICommand
    {
        private Benefit benefit;
        private List<Benefit> benefits;

        public RemoveBenefitCommand(Benefit benefit, List<Benefit> benefits)
        {
            this.benefit = benefit;
            this.benefits = benefits;
        }

        public void Execute()
        {
            benefits.Remove(benefit);
        }
    }
}
