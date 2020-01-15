using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CommandExecutor : ICommandExecutor
    {
        IDictionary<string, ICommand> commandDictionary;

        public CommandExecutor()
        {
            commandDictionary = new Dictionary<string, ICommand>();
            this.AddToCommandDictionary();
        }

        private void AddToCommandDictionary()
        {
            commandDictionary.Add("helpStart", new GameFormCommand(new HelpInputForm()));
            commandDictionary.Add("gameInput", new GameFormCommand(new GameInputForm()));
            commandDictionary.Add("cardInput", new GameFormCommand(new CardInputForm()));
            commandDictionary.Add("TAKE OFF BALLS", new GameFormCommand(new BallExtractorInputForm()));
        }

        public ICommand GetCommandFromDictionary(string command)
        {
            ICommand result = null;

            foreach (KeyValuePair<string, ICommand> item in commandDictionary)
            {
                if (item.Key == command)
                {
                    return result = item.Value;
                }
            }

            return result;
        }
    }
}
