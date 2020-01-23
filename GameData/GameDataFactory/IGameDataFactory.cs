namespace BingoGame
{
    public interface IGameDataFactory
    {
        IGameData CreateGameData(int optionNumber, int quantityOfCards);
    }
}