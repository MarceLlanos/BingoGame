using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class BingoRange : IRange
    {
        int column;
        int row;

        public BingoRange()
        {
            column = 5;
            row = 5;
        }
        public int GetEnd()
        {
            return row;
        }
        

        public int GetStart()
        {
            return column;
        }

        public void SetEnd(int end)
        {
            this.row = end;
        }

        public void SetStart(int start)
        {
            this.column = start;
        }
    }
}
