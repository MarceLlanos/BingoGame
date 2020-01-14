using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoker = new Invoker();
            var reciever = new Reciever();
            invoker.SetGameMenuCommand(new GameFormCommand(reciever));
            var optionGame = invoker.ShowGameOptionMenu();
            var quantityOfCards = invoker.ShowCardOption();

            IGameSettingFactory gameDataSetting = new GameSettingFactory();

            var gameSetting = gameDataSetting.CreateGameSetting(int.Parse(optionGame), int.Parse(quantityOfCards), 0);
            var packOfCards = new CardPackage(gameSetting);
            packOfCards.DrawDeckOfCards();
            Console.WriteLine(" ");
            packOfCards.ShowCards();

            Console.ReadKey();
        }
    }
}
