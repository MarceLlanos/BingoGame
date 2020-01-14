using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class Reciever : IReciever
    {
        ServiceLocator service;

        public Reciever()
        {
            service = new ServiceLocator();
        }

        public string GameOptionFormComplete()
        {
            Console.WriteLine("Choose the type of the game");
            Console.WriteLine("1 = 75 ball bingo Game.");
            Console.WriteLine("2 = 90 ball bingo Game or Housie/Bingo Game");
            return Console.ReadLine();
        }

        public string CardsOptionFormComplete()
        {
            Console.WriteLine("");
            Console.WriteLine("How many cards do you want?");
            return Console.ReadLine();
        }
    }
}
