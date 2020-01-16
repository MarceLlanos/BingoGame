using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class ShowCommand : ICommand<ICardPackage>
    {
        public void ExecuteCommand(ICardPackage bingoComponent)
        {
            bingoComponent.ShowCards();
        }
    }
}
