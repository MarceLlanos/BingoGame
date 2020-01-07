using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class RandomGenerator : IRandomGenerator
    {
        List<int> columns;
        Random random = new Random();

        public RandomGenerator()
        {
            columns = new List<int>();
        }
       
        public List<int> GenerateRandomUniqueNumbers(IRange range, int quantity)
        {
            for (int i = 0; i < quantity; i++)
            {
                var randomNumber = random.Next(range.GetStart(), range.GetEnd());

                if (!columns.Contains(randomNumber))
                {
                    columns.Add(randomNumber);

                }
            }
            
            return columns;
        }
    }
}
