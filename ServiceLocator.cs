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
            serviceDictionary.Add("ballMachine", new BallMachineFactory());
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
            serviceDictionary.Add("executeShowCards", new CommandShowCardsExecutorFactory());
            serviceDictionary.Add("executeWinner", null);
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
