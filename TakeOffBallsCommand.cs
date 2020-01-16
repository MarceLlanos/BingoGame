using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class TakeOffBallsCommand : ICommand<IRandomExtractorBallsMachineFactory>
    {
        ServiceLocator service;

        public TakeOffBallsCommand()
        {
            service = new ServiceLocator();
        }

        public void ExecuteCommand(IRandomExtractorBallsMachineFactory bingoComponent)
        {
            Console.WriteLine("How many bingo balls do you want to take off?");
            var quantityOfBalls = Console.ReadLine();

            bingoComponent.CreateRandomExtractorBallsMachine(service, int.Parse(quantityOfBalls));
        }
    }
}
