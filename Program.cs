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
            var cardInfomation = new CardDataMenu();
            var deckOfCards = new CardShuffler();

            Console.WriteLine("Choose the type of the game");
            Console.WriteLine("1 = 75 ball bingo Game.");
            Console.WriteLine("2 = 90 ball bingo Game or Housie/Bingo Game");
            string optionGame = Console.ReadLine();
            var card= cardInfomation.GetCardData(optionGame);

            Console.WriteLine("");
            Console.WriteLine("Choose mode to win the game.");
            Console.WriteLine("1= Win the game if someone shape one of the patterns shape.");
            Console.WriteLine("2= Win the game if someone full the card.");
            string optionWin = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("How many cards do you want?");
            string optionQuantity = Console.ReadLine();
            deckOfCards.DeckOfCards(int.Parse(optionQuantity), card);

            Console.WriteLine(" ");

            deckOfCards.ShowDeckOfCards();
            Console.ReadKey();
        }
    }
}
