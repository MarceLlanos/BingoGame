﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface IInvoker
    {
        void SetGameMenuCommand(ICommand command);
        void SetCommandExecutor(ICommandExecutor command);
        string ShowInputOptionMenu();
        string ShowInputMenu(string command);
    }
}
