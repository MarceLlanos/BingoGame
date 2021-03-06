﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface ICommandExecutor<T>
    {
        void ExecuteCommand(string commandName, T bingoComponent);
        void AddToDictionary(string commandName, ICommand<T> command);
    }
}
