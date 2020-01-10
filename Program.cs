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
            var gameDataSetting = new GameSettingFactory();

            Console.WriteLine("Choose the type of the game");
            Console.WriteLine("1 = 75 ball bingo Game.");
            Console.WriteLine("2 = 90 ball bingo Game or Housie/Bingo Game");
            string optionGame = Console.ReadLine();


            Console.WriteLine("");
            Console.WriteLine("How many cards do you want?");
            string quantityOfCards = Console.ReadLine();

            var gameSetting = gameDataSetting.CreateGameSetting(int.Parse(optionGame), int.Parse(quantityOfCards), 0);

            var packOfCards = new CardPackage(gameSetting);

            packOfCards.DeckOfCards();

            Console.WriteLine(" ");

            packOfCards.ShowCards();

            Console.WriteLine("How many balls do you want to drew?");
            string quantityBalls = Console.ReadLine();


            Console.ReadKey();
        }
    }
}
