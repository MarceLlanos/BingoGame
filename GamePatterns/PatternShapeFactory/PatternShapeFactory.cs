using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class PatternShapeFactory : IPatternShapeFactory
    {
        public IPatternShape CreatePatternVerifier(ServiceLocator service)
        {
            var gameConfiguration = service.GetService<IGameConfigurationFactory>("gameConfiguration").CreateGameSetting(service);
            var quantityOfBalls = gameConfiguration.GetGameData().GetQuantityOfBalls(); ;

            switch (quantityOfBalls)
            {
                case 75: return new BingoPatternsShapeFactory().CreatePatternVerifier(service);
                case 90: return new HousiePatternsShapeFactory().CreatePatternVerifier(service);
            }

            return new BingoPatternsShapeFactory().CreatePatternVerifier(service);
        }
    }
}
