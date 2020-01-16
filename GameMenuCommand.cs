using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class GameMenuCommand : ICommand<IGameSettingFactory>
    {
        public void ExecuteCommand(IGameSettingFactory bingoComponent)
        {
            Console.WriteLine("");
            Console.WriteLine(" Choose the type of the game");
            Console.WriteLine(" 1 = 75 ball bingo Game.");
            Console.WriteLine(" 2 = 90 ball bingo Game or Housie/Bingo Game");
            var typeOfGame = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine(" How many cards do you want?");
            var quantityOfCards = Console.ReadLine();

            bingoComponent.CreateGameSetting(int.Parse(typeOfGame), int.Parse(quantityOfCards), 0);

            Console.WriteLine("");
            Console.WriteLine("Bingo Game:");
            Console.WriteLine("PLAY = Start the game");
            Console.WriteLine("HELP = Show the commands for play");
            Console.WriteLine("CANCEL = Finish the game");
        }
    }
}
