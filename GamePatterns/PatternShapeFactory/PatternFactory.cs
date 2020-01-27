using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class PatternFactory : IPatternFactory
    {
        public IPattern CreatePatternVerifier(ServiceLocator service)
        {
            var gameConfiguration = service.GetService<IGameConfigurationFactory>("gameConfiguration").CreateGameSetting(service);
            var quantityOfBalls = gameConfiguration.GetGameData().GetQuantityOfBalls(); ;

            switch (quantityOfBalls)
            {
                case 75: return new BingoPatternsFactory().CreatePatternVerifier(service);
                case 90: return new HousiePatternsFactory().CreatePatternVerifier(service);
            }

            return new BingoPatternsFactory().CreatePatternVerifier(service);
        }
    }
}
