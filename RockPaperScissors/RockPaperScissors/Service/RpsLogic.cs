using RockPaperScissors.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.Service
{
    public class RpsLogic
    {
        private readonly Random random;

        public RpsLogic(Random random)
        {
            this.random = random;
        }

        public Rps userData { get; set; }

        public void GameRound(RpsMode UserChoice)
        {
            RpsMode aiChoice = (RpsMode)random.Next(1, 4);

            if (aiChoice == RpsMode.Rock && UserChoice == RpsMode.Paper
                || aiChoice == RpsMode.Scissors && UserChoice == RpsMode.Rock
                || aiChoice == RpsMode.Paper && UserChoice == RpsMode.Scissors)
            {
                userData.WinCounter++;
                userData.IsWinner = true;
            }
            else if (aiChoice == UserChoice)
            {
                userData.DrawCounter++;
                userData.IsWinner = null;
            }
            else
            {
                userData.LossCounter++;
                userData.IsWinner = false;
            }
        }
    }
}
