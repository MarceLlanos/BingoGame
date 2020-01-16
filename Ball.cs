using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class Ball : IBall
    {
        int numberBall;
        bool extracted;

        public Ball(int numberBall, bool extracted)
        {
            this.numberBall = numberBall;
            this.extracted = extracted;
        }

        public int GetNumber()
        {
            return numberBall;
        }

        public bool IsExtracted()
        {
            return extracted;
        }

        public void SetIsExtracted(bool extracted)
        {
            this.extracted = extracted;
        }

        public void ShowBall()
        {
            Console.WriteLine("Number: {0}", numberBall);
            Console.WriteLine("State: {0}", extracted);
            Console.WriteLine(" ");
        }
    }
}
