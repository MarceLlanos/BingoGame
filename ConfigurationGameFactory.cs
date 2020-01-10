using System;
namespace BingoGame
{
    public class ConfigurationGameFactory:IConfigurationGameFactory
    {
        public ConfigurationGameFactory()
        {
        }

        public IConfigurationGame CreateConfigurationGame( int optionGame, int quantityCards )
        {
            var dataCard = new DataCardFactory().CreateDataCard( optionGame );

            return new ConfigurationGame( dataCard, quantityCards);
        }
    }
}
