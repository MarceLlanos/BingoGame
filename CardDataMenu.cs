using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardDataMenu : ICardDataMenu
    {
        public ICard GetCardData(string option)
        {
            switch (option)
            {
                case "1":
                    return new Card(new BingoData());
                case "2":
                    return new Card(new HousieData());
                default:
                    return new Card(new BingoData());

            }
        }
    }
}
