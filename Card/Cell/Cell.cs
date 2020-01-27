using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class Cell : ICell
    {
        string valueOfCell;
        bool isCrossoutTheCell;

        public Cell(string valueOfCell, bool isCrossoutTheCell)
        {
            this.valueOfCell = valueOfCell;
            this.isCrossoutTheCell = isCrossoutTheCell;
        }

        public string GetValueCell()
        {
            return valueOfCell;
        }

        public bool IsCrossoutTheCell()
        {
            return isCrossoutTheCell;
        }

        public void SetCrossoutTheCell(bool isCrossoutTheCell)
        {
            this.isCrossoutTheCell = isCrossoutTheCell;
        }

        public void SetVelueOfCell(string valueOfCell)
        {
            this.valueOfCell = valueOfCell;
        }

        public void PrintCell()
        {
            Console.Write("{0}" + " ", this.GetValueCell());
        }
    }
}
