﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class CardFiller : ICardFiller
    {
        ICard card;
        public CardFiller(ICard card)
        {
            this.card = card;
        }

        public string[,] FillCard(List<int> randomNumbers, int columnIndex)
        {
            var rowNumber = randomNumbers.Count;
            var cardBoard = card.GetCard();

            for (int j = 0; j < rowNumber; j++)
            {
                cardBoard[columnIndex, j] = string.Format("{0}", randomNumbers[j]);
            }

            return cardBoard;
        }

    }
}
