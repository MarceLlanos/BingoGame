﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class BallMachineFactory : IBallMachineFactory
    {
        public IBallMachine CreateBallMachine(ServiceLocator service)
        {
            var gameConfiguration = service.GetService<IGameConfigurationFactory>("gameConfiguration");
            var quantityOfBalls = gameConfiguration.CreateGameSetting(service).GetGameData().GetQuantityOfBalls();
            var ballMachine = service.GetService<IBallMachine>("ballMachine");
            ballMachine.BallMaker(new Ball(0, false), quantityOfBalls);

            return ballMachine;
        }
    }
}
