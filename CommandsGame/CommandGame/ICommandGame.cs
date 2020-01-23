using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface ICommandGame
    {
        void GetCommand(ServiceLocator service);
    }
}
