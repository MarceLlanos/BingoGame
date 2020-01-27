using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class BingoPatternsFactory : IPatternFactory
    {
        public IPattern CreatePatternVerifier(ServiceLocator service)
        {
            var horizontalOne = service.GetService<IPattern>("horizontalOne");
            var horizontalTwo = service.GetService<IPattern>("horizontalTwo");
            var horizontalThree = service.GetService<IPattern>("horizontaThree");
            var horizontalFour = service.GetService<IPattern>("horizontalFour");
            var horizontalFive = service.GetService<IPattern>("horizontalFive");
            var verticalOne = service.GetService<IPattern>("verticalOne");
            var verticalTwo = service.GetService<IPattern>("verticalTwo");
            var verticalThree = service.GetService<IPattern>("verticalThree");
            var verticalFour = service.GetService<IPattern>("verticalFour");
            var verticalFive = service.GetService<IPattern>("verticalFive");
            var diagonal = service.GetService<IPattern>("diagonal");
            var diagonalInverted = service.GetService<IPattern>("diagonalInverted");
            var doubleDiagonal = service.GetService<IPattern>("doubleDiagonal");
            var fourCorners = service.GetService<IPattern>("fourCorners");
            var lNormal = service.GetService<IPattern>("lNormal");
            var lInverted = service.GetService<IPattern>("lInverted");
            var square = service.GetService<IPattern>("square");
            var fullHouse = service.GetService<IPattern>("fullCard");

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
