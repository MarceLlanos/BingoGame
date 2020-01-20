﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class GameMenuCommand : ICommand
    {

        public void GameInitCommand(ServiceLocator service)
        {
            var userConfiguration = service.GetService<IUserInputConfiguration>("userConfiguration");

            Console.WriteLine("");
            Console.WriteLine("Choose the type of the game");
            Console.WriteLine("1 = 75 ball bingo Game.");
            Console.WriteLine("2 = 90 ball bingo Game or Housie/Bingo Game");
            var typeOfGame = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("How many cards do you want?");
            var quantityOfCards = Console.ReadLine();

            userConfiguration.SetOptionGame(int.Parse(typeOfGame));
            userConfiguration.SetQuantityOfCards(int.Parse(quantityOfCards));
            var gameConfiguration = service.GetService<IGameConfigurationFactory>("gameConfiguration").CreateGameSetting(service);
            
            var cardSet = service.GetService<ICardSetFactory>("cardSet").CreateCardSet(service);
            var ballMachine = service.GetService<IBallMachineFactory>("ballMachine").CreateBallMachine(service);

            Console.WriteLine("");
            Console.WriteLine("Bingo Game:");
            Console.WriteLine("PLAY = Start the game");
            Console.WriteLine("HELP = Show the commands for play");
            Console.WriteLine("CANCEL = Finish the game");
            Console.WriteLine("");
        }
    }

    public interface ICommand
    {
        void GameInitCommand(ServiceLocator service);
    }
}
