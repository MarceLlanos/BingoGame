using System;
namespace BingoGame
{
    public interface IConfigurationGameFactory
    {
        IConfigurationGame CreateConfigurationGame(int optionGame, int quantityCards);
    }
}
