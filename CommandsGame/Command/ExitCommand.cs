namespace BingoGame
{
    internal class ExitCommand : ICommand<ExitAction>
    {
        public void ExecuteCommand(ExitAction bingoComponent)
        {
            bingoComponent.ShowAction();
        }
    }
}