using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class Invoker : IInvoker
    {
        ICommand command;
        ServiceLocator service;

        public Invoker()
        {
            service = new ServiceLocator();
        }

        public void SetGameMenuCommand(ICommand command)
        {
            this.command = command;
        }

        public string ShowCardOption()
        {
            return this.command.executeCardOption();
        }

        public string ShowGameOptionMenu()
        {
            return this.command.executeGameOption();
        }
    }
}
