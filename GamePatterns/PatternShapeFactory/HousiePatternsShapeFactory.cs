using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class HousiePatternsShapeFactory : IPatternShapeFactory
    {
        public IPatternShape CreatePatternVerifier(ServiceLocator service)
        {
            var oneLineOne = service.GetService<IPatternShape>("oneLineOne");
            var oneLineTwo = service.GetService<IPatternShape>("oneLineTwo");
            var oneLineThree = service.GetService<IPatternShape>("oneLineThree");
            var twoLineOne = service.GetService<IPatternShape>("twoLineOne");
            var twoLineTwo = service.GetService<IPatternShape>("twoLineTwo");
            var twoLineThree = service.GetService<IPatternShape>("twoLineThree");
            var fullHouse = service.GetService<IPatternShape>("fullHouse");

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
