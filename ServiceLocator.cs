using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class ServiceLocator : IServiceLocator
    {
        IDictionary<object, object> serviceDictionary;

        public ServiceLocator()
        {
            this.serviceDictionary = new Dictionary<object, object>();
            this.BuildServiceDictionary();
        }

        private void BuildServiceDictionary()
        {
            serviceDictionary.Add("gameSettingFactory", new GameSettingFactory());
            serviceDictionary.Add("ballsGenerator", new BallsGenerator(0));
            serviceDictionary.Add("bingoDictonary", new BingoRangeDictionaryFiller());
            serviceDictionary.Add("housieDictonary", new HousieRangeDictionaryFiller());
            serviceDictionary.Add("randomNumbersGenerator", new RandomNumbersGenerator());
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
