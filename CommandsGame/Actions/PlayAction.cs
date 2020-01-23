using System;

namespace BingoGame
{
    public class PlayAction : IAction
    {
        public void ShowAction()
        {
            Console.WriteLine("START THE GAME!!!");
        }
    }
}