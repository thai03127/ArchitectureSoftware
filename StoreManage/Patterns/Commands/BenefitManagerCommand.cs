namespace StoreManage.Patterns.Commands
{
    internal class BenefitManagerCommand
    {
        private List<ICommand> commands = new List<ICommand>();

        public void AddCommand(ICommand command)
        {
            commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in commands)
            {
                command.Execute();
            }
            commands.Clear(); // Clear executed commands
        }
    }
}
