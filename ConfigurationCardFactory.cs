using System;
namespace BingoGame
{
    public class ConfigurationCardFactory:ICardConfigurationFactory
    {
        public ConfigurationCardFactory()
        {
        }

        public ICardConfiguration CreateCardConfiguration(int optionGame, int quantityCards)
        {
            throw new NotImplementedException();
        }
    }
}
