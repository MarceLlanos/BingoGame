namespace BingoGame
{
    public class CommandShowCardsExecutorFactory : ICommandExecutorFactory<ServiceLocator>
    {
        public ICommandExecutor<ServiceLocator> CreateCommandExecutor()
        {
            var showExecute = new CommandExecutor<ServiceLocator>();
            showExecute.AddToDictionary("SHOW CARDS", new ShowCardsCommand());
            showExecute.AddToDictionary("SHOW BALLS", new ShowBallsCommand());
            showExecute.AddToDictionary("SHOW TAKE OFF BALLS", new ShowDropBallsCommand());
            showExecute.AddToDictionary("TAKE OFF BALLS", new TakeOffBallsCommand());
            return showExecute;
        }
    }
}