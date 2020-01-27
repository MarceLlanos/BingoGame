using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface ICell
    {
        string GetValueCell();
        bool IsCrossoutTheCell();
        void SetVelueOfCell(string velueOfCell);
        void SetCrossoutTheCell(bool isCrossoutTheCell);
        void PrintCell();
    }
}
