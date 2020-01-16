using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class ShowDropBallsCommand : ICommand<IRandomExtractorBallsMachine>
    {
        public void ExecuteCommand(IRandomExtractorBallsMachine bingoComponent)
        {
            bingoComponent.ShowExtractedBallsFromMachine();
        }
    }
}
