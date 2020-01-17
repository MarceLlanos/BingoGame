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
            var commandGame = new CommandGame();
            var gameMenu = service.GetService<CommandGameExecutorFactory>("executeGame");

            gameMenu.CreateCommandExecutor().ExecuteCommand("Bingo", new UserInputConfiguration());
            commandGame.GetCommand(service);

            Console.ReadKey();
        }
    }
}
