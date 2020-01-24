using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    public class ServiceLocator : IServiceLocator
    {
        IDictionary<object, object> serviceDictionary;

        public ServiceLocator()
        {
            this.serviceDictionary = new Dictionary<object, object>();
            this.BuildServiceDictionary();
        }

        private void BuildServiceDictionary()
        {
            serviceDictionary.Add("gameConfiguration", new GameConfigurationFactory());
            serviceDictionary.Add("extractedMachine", new RandomExtractorBallsMachineFactory());
            serviceDictionary.Add("ballMachine", new BallMachine());
            serviceDictionary.Add("ballMachineFactory", new BallMachineFactory());
            serviceDictionary.Add("rangeDictionaryFactory", new RangeDictionaryFactory());
            serviceDictionary.Add("bingoDictonary", new BingoRangeDictionaryFiller());
            serviceDictionary.Add("housieDictonary", new HousieRangeDictionaryFiller());
            serviceDictionary.Add("randomNumbersGenerator", new RandomNumbersGenerator());
            serviceDictionary.Add("cardPrototypeFactory", new CardPrototypeFactory());
            serviceDictionary.Add("cardSet", new CardSet(this));
            serviceDictionary.Add("cardSetFactory", new CardSetFactory());
            serviceDictionary.Add("cardFactory", new CardFactory());
            serviceDictionary.Add("blankSpace", new BlankSpaceInjectorFactory());
            serviceDictionary.Add("gameInput", new GameMenuCommand());
            serviceDictionary.Add("userConfiguration", new UserInputConfiguration());
            serviceDictionary.Add("cardDataFactory", new CardDataFactory());
            serviceDictionary.Add("gameDataFactory", new GameDataFactory());
            serviceDictionary.Add("executeGame", new CommandGameExecutorFactory());
            serviceDictionary.Add("executeHelp", new CommandHelpExecutorFactory());
            serviceDictionary.Add("executePlay", new CommandPlayExecutorFactory());
            serviceDictionary.Add("executeExit", new CommandExitExecutorFactory());
            serviceDictionary.Add("executeShowCards", new CommandShowExecutorFactory());
            serviceDictionary.Add("executeWinner", null);
            serviceDictionary.Add("diagonal", new DiagonalPattern());
            serviceDictionary.Add("diagonalInverted", new DiagonalInvertedPattern());
            serviceDictionary.Add("doubleDiagonal",new DoubleDiagonalPattern());
            serviceDictionary.Add("fourCorners", new FourCornersPattern());
            serviceDictionary.Add("fullCard", new FullCardBingoPattern());
            serviceDictionary.Add("horizontalOne", new HorizontalLineOnePattern());
            serviceDictionary.Add("horizontalTwo", new HorizontalLineTwoPattern());
            serviceDictionary.Add("horizontalThree", new HorizoltalLineThreePattern());
            serviceDictionary.Add("horizontalFour", new HorizontalLineFourPattern());
            serviceDictionary.Add("horizontalFive", new HorizontalLineFivePattern());
            serviceDictionary.Add("verticalOne", new VerticalLineOnePattern());
            serviceDictionary.Add("verticalTwo", new VerticalLineTwoPattern());
            serviceDictionary.Add("verticalThree", new VerticalLineThreePattern());
            serviceDictionary.Add("verticalFour", new VerticalLineFourPattern());
            serviceDictionary.Add("verticalFive", new VerticalLineFivePattern());
            serviceDictionary.Add("lNormal", new LPattern());
            serviceDictionary.Add("lInverted", new LInvertedPattern());
            serviceDictionary.Add("square", new SquarePattern());
            serviceDictionary.Add("fullHouse", new FullHousePattern());
            serviceDictionary.Add("oneLineOne", new OneLineZeroPattern());
            serviceDictionary.Add("oneLineTwo", new OneLineOnePattern());
            serviceDictionary.Add("oneLineThree", new OneLineTwoPattern());
            serviceDictionary.Add("twoLineOne", new TwoLineOnePattern());
            serviceDictionary.Add("twoLineTwo", new TwoLineTwoPattern());
            serviceDictionary.Add("twoLineThree", new TwoLineThreePattern());
            serviceDictionary.Add("patternShapeFactory", new PatternShapeFactory());
            serviceDictionary.Add("patternShapeVerifier", new PatternShapeVerifier());
        }

        public T GetService<T>(object key)
        {
            T result = default(T);

            try
            {
                foreach (KeyValuePair<object, object> item in serviceDictionary)
                {
                    if (item.Key == key)
                    {
                        return result = (T)item.Value;
                    }
                }

                return result;
            }
            catch
            {
                throw new NotImplementedException("Service not available.");
            }
        }
    }
}
