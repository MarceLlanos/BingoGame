using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class HousiePatternsFactory : IPatternFactory
    {
        public IPattern CreatePatternVerifier(ServiceLocator service)
        {
            var oneLineOne = service.GetService<IPattern>("oneLineOne");
            var oneLineTwo = service.GetService<IPattern>("oneLineTwo");
            var oneLineThree = service.GetService<IPattern>("oneLineThree");
            var twoLineOne = service.GetService<IPattern>("twoLineOne");
            var twoLineTwo = service.GetService<IPattern>("twoLineTwo");
            var twoLineThree = service.GetService<IPattern>("twoLineThree");
            var fullHouse = service.GetService<IPattern>("fullHouse");

            oneLineOne.SetNextPattern(oneLineTwo);
            oneLineTwo.SetNextPattern(oneLineThree);
            oneLineThree.SetNextPattern(twoLineOne);
            twoLineOne.SetNextPattern(twoLineTwo);
            twoLineTwo.SetNextPattern(twoLineThree);
            twoLineThree.SetNextPattern(fullHouse);

            return oneLineOne;
        }
    }
}
