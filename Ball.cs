﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class Ball:IBall
    {
        int numberBall;
        bool takenBall;

        public Ball(int numberBall, bool takenBall)
        {
            this.numberBall = numberBall;
            this.takenBall = takenBall;
        }

        public int GetNumberOfBall()
        {
            return numberBall;
        }

        public bool WasTakenTheBall()
        {
            return takenBall;
        }
    }
}