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
            ServiceLocator service = new ServiceLocator();

            var inputMenu = service.GetService<IInvoker>("invoker");
            inputMenu.SetCommandExecutor(new CommandExecutor());

            var optionGame = inputMenu.ShowInputMenu("gameInput");
            var quantityOfCards = inputMenu.ShowInputMenu("cardInput");
            var helpStart = inputMenu.ShowInputMenu("helpStart");
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
