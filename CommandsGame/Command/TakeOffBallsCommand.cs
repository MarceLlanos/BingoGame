using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class TakeOffBallsCommand : ICommand<ServiceLocator>
    {
        ServiceLocator service;

        public TakeOffBallsCommand()
        {
            service = new ServiceLocator();
        }

        public void ExecuteCommand(ServiceLocator service)
        {
            var ballMachine = service.GetService<IBallMachine>("ballMachine");
            var cards = service.GetService<ICardSet>("cardSet");

            Console.WriteLine("How many bingo balls do you want to take off?");
            var quantityOfBalls = Console.ReadLine();

            var ballsExtracted = ballMachine.GetBalls(int.Parse(quantityOfBalls));
            cards.CrossoutCards(ballsExtracted);
        }
    }
}
