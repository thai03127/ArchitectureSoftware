using StoreManage.Models;

namespace StoreManage.Patterns.Commands
{
    public class RemoveBenefitCommand : ICommand
    {
        private Benefit _benefit;

        public RemoveBenefitCommand(Benefit benefit)
        {
            _benefit = benefit;
        }

        public void Execute()
        {
            _benefit.Remove();
        }

        public void Undo()
        {
            _benefit.Add();
        }
    }
}
