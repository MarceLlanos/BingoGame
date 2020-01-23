using System;

namespace BingoGame
{
    public interface IServiceLocator
    {
        T GetService<T>(object key);
    }
}