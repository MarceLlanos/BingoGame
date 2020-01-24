using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class BingoPatternsShapeFactory : IPatternShapeFactory
    {
        public IPatternShape CreatePatternVerifier(ServiceLocator service)
        {
            var horizontalOne = service.GetService<IPatternShape>("horizontalOne");
            var horizontalTwo = service.GetService<IPatternShape>("horizontalTwo");
            var horizontalThree = service.GetService<IPatternShape>("horizontaThree");
            var horizontalFour = service.GetService<IPatternShape>("horizontalFour");
            var horizontalFive = service.GetService<IPatternShape>("horizontalFive");
            var verticalOne = service.GetService<IPatternShape>("verticalOne");
            var verticalTwo = service.GetService<IPatternShape>("verticalTwo");
            var verticalThree = service.GetService<IPatternShape>("verticalThree");
            var verticalFour = service.GetService<IPatternShape>("verticalFour");
            var verticalFive = service.GetService<IPatternShape>("verticalFive");
            var diagonal = service.GetService<IPatternShape>("diagonal");
            var diagonalInverted = service.GetService<IPatternShape>("diagonalInverted");
            var doubleDiagonal = service.GetService<IPatternShape>("doubleDiagonal");
            var fourCorners = service.GetService<IPatternShape>("fourCorners");
            var lNormal = service.GetService<IPatternShape>("lNormal");
            var lInverted = service.GetService<IPatternShape>("lInverted");
            var square = service.GetService<IPatternShape>("square");
            var fullHouse = service.GetService<IPatternShape>("fullCard");

            horizontalOne.SetNextPattern(horizontalTwo);
            horizontalTwo.SetNextPattern(horizontalThree);
            horizontalFour.SetNextPattern(horizontalFive);
            horizontalFive.SetNextPattern(verticalOne);
            verticalOne.SetNextPattern(verticalTwo);
            verticalTwo.SetNextPattern(verticalThree);
            verticalThree.SetNextPattern(verticalFour);
            verticalFour.SetNextPattern(verticalFive);
            verticalFive.SetNextPattern(diagonal);
            diagonal.SetNextPattern(diagonalInverted);
            diagonalInverted.SetNextPattern(doubleDiagonal);
            doubleDiagonal.SetNextPattern(fourCorners);
            fourCorners.SetNextPattern(lNormal);
            lNormal.SetNextPattern(lInverted);
            lInverted.SetNextPattern(square);
            square.SetNextPattern(fullHouse);

            return horizontalOne;
        }
    }
}
