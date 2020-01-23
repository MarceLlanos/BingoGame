namespace BingoGame
{
    internal class PlayCommand : ICommand<PlayAction>
    {
        public void ExecuteCommand(PlayAction bingoComponent)
        {
            bingoComponent.ShowAction();
        }
    }
}