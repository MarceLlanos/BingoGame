using System;
namespace BingoGame
{
    public interface IDataCardFactory
    {
        IDataCard CreateDataCard(int option);
    }
}
