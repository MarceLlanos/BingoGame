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
            var cardInfomation = new CardDataFactory();
            var cards = new GeneratorCards();

            Console.WriteLine("Choose the type of the game");
            Console.WriteLine("1 = 75 ball bingo Game.");
            Console.WriteLine("2 = 90 ball bingo Game or Housie/Bingo Game");
            string optionGame = Console.ReadLine();
            var dataCard= cardInfomation.GetCardData(optionGame);

            Console.WriteLine("");
            Console.WriteLine("Choose mode to win the game.");
            Console.WriteLine("1= Win the game if someone shape one of the patterns shape.");
            Console.WriteLine("2= Win the game if someone full the card.");
            string optionWin = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("How many cards do you want?");
            string optionQuantity = Console.ReadLine();
            cards.GenerateCards(int.Parse(optionQuantity), dataCard);
            dataCard.showCard();

        }
    }
}
