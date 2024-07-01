namespace StoreManage.Patterns.Commands
{
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
}
