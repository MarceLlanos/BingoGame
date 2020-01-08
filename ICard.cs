using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public interface ICard
    {
        ICardData GetCardData();
        string[,] GetCard();
        string[,] Draw(List<int>randomNumbers, int columnIndex);
        void SetCard(string[,] card);
        //void BlankSpaces(List<int> rowBlankSpaces);
        string PrintRow(int rowIndex);
    }
}
