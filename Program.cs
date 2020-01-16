using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new ServiceLocator();
            var commandsDirectory = new CommandHelpExecutorFactory();
            var gameMenu = service.GetService<CommandGameExecutorFactory>("executeGame");
            gameMenu.CreateCommandExecutor().ExecuteCommand("Bingo", new GameSettingFactory());

            while (true)
            {
                Console.WriteLine("Enter a command");
                var command = Console.ReadLine();

                commandsDirectory.CreateCommandExecutor().ExecuteCommand(command, new HelpAction());
            }

            Console.ReadKey();
        }
    }
}
