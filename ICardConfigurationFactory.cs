namespace BingoGame
{
    public interface ICardConfigurationFactory
    {
        ICardConfiguration CreateCardConfiguration(int optionGame, int quantityCards);
    }
}