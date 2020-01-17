using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CommandGame
    {
        public void GetCommand(ServiceLocator service)
        {
            var helpCommand = new CommandHelpExecutorFactory();
            var playCommand = service.GetService<CommandPlayExecutorFactory>("executePlay");
            var exitCommand = service.GetService<CommandExitExecutorFactory>("executeExit");
            var showCardsCommand = service.GetService<CommandShowCardsExecutorFactory>("executeShowCards");
            var showBallsCommand = service.GetService<CommandShowBallsExecutorFactory>("executeShowBalls");
            var showDropBallsCommand = service.GetService<CommandDropBallsExecutorFactory>("executeDropBalls");
            var takeOffBallsCommand = service.GetService<CommandTakeOffBallsExecutorFactory>("executeTakeOff");

            while (true)
            {
                Console.WriteLine("Enter a command please!.");
                var command = Console.ReadLine();

                helpCommand.CreateCommandExecutor().ExecuteCommand(command, new HelpAction());
                playCommand.CreateCommandExecutor().ExecuteCommand(command, new PlayAction());
                exitCommand.CreateCommandExecutor().ExecuteCommand(command, new ExitAction());
                showCardsCommand.CreateCommandExecutor().ExecuteCommand(command, new CardSet());
                showBallsCommand.CreateCommandExecutor().ExecuteCommand(command, new BallMachine());
                showDropBallsCommand.CreateCommandExecutor().ExecuteCommand(command, new RandomExtractorBallsMachine(new UnExtractedBalls(new BallMachine())));
                takeOffBallsCommand.CreateCommandExecutor().ExecuteCommand(command, new RandomExtractorBallsMachineFactory());

                if (service == null)
                {
                    Console.WriteLine("Please enter a valid command!");
                }
            }
        }
    }
}
