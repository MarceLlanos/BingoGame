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
            serviceDictionary.Add("gameDataSetting", new GameDataSetting(null, null, 0));
            serviceDictionary.Add("gameSettingFactory", new GameSettingFactory());
            serviceDictionary.Add("ballsMachine", new BallMachine());
            serviceDictionary.Add("bingoDictonary", new BingoRangeDictionaryFiller());
            serviceDictionary.Add("housieDictonary", new HousieRangeDictionaryFiller());
            serviceDictionary.Add("randomNumbersGenerator", new RandomNumbersGenerator());
            serviceDictionary.Add("gameInput", new GameMenuCommand());

            serviceDictionary.Add("executeGame", new CommandGameExecutorFactory());
            serviceDictionary.Add("executeHelp", new CommandHelpExecutorFactory());
            serviceDictionary.Add("executePlay", new CommandPlayExecutorFactory());
            serviceDictionary.Add("executeExit", new CommandExitExecutorFactory());
            serviceDictionary.Add("executeShowCards", new CommandShowCardsExecutorFactory());
            serviceDictionary.Add("executeWinner", null);
            serviceDictionary.Add("executeShowBalls", new CommandShowBallsExecutorFactory());
            serviceDictionary.Add("executeDropBalls", new CommandDropBallsExecutorFactory());
            serviceDictionary.Add("executeTakeOff", new CommandTakeOffBallsExecutorFactory());
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
