using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class RandomDrawBalls : IRandomDrawBalls
    {
        IRandomNumbersGenerator randomNumbers;
        IGameDataSetting gameDataSetting;

        public RandomDrawBalls(IGameDataSetting gameDataSetting)
        {
            this.gameDataSetting = gameDataSetting;
            randomNumbers = new RandomNumbersGenerator();
        }

        public List<int> TakenOutBalls(int quantityOfTakenBalls)
        {
            var takenBalls = new List<int>();
            var quantityOfBalls = gameDataSetting.GetGameData().GetQuantityOfBalls();
            var numbersTaken = randomNumbers.GenerateDistinctRandomNumbers(new Range(1, quantityOfBalls), quantityOfTakenBalls);

            return null;
        }
    }
}
