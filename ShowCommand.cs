﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class ShowCommand : ICommand<ICardSet>
    {
        public void ExecuteCommand(ICardSet bingoComponent)
        {
            bingoComponent.ShowCards();
        }
    }
}
