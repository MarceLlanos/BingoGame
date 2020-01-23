namespace BingoGame
{
    public class CommandShowExecutorFactory : ICommandExecutorFactory<ServiceLocator>
    {
        public ICommandExecutor<ServiceLocator> CreateCommandExecutor()
        {
            var showExecute = new CommandExecutor<ServiceLocator>();
            showExecute.AddToDictionary("SHOW CARDS", new ShowCardsCommand());
            showExecute.AddToDictionary("SHOW CARDS CROSSOUT", new ShowCrossoutCardsCommand());
            showExecute.AddToDictionary("SHOW BALLS", new ShowBallsCommand());
            showExecute.AddToDictionary("SHOW TAKE OFF BALLS", new ShowExtractedBallsCommand());
            showExecute.AddToDictionary("SHOW ALL EXTRACTED BALLS", new ShowAllExtractedBallsCommand());
            showExecute.AddToDictionary("TAKE OFF BALLS", new TakeOffBallsCommand());
            return showExecute;
        }
    }
}