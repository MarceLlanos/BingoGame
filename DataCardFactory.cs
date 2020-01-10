using System;
namespace BingoGame
{
    public class DataCardFactory:IDataCardFactory
    {
        public DataCardFactory()
        {
        }

        public IDataCard CreateDataCard(int option)
        {
            switch (option)
            {
                case 1: return new DataCard(5, 5, 75);
                case 2: return new DataCard(9, 3, 90);
            }

            return new DataCard(5, 5, 75);
        }
    }
}
