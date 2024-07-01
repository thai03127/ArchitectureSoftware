using StoreManage.Models;

namespace StoreManage.Patterns.Commands
{
    internal class AddBenefitCommand : ICommand
    {
        private Benefit _benefit;

        public AddBenefitCommand(Benefit benefit)
        {
            _benefit = benefit;
        }

        public void Execute()
        {
            _benefit.Add();
        }

        public void Undo()
        {
            _benefit.Remove();
        }
    }
}
