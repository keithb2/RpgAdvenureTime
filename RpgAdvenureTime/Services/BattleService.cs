using System;
using System.Collections.Generic;
using System.Text;

namespace RpgAdvenureTime.Services
{
    public class BattleService
    {
        public BattleResult Fight()
        {
            return BattleResult.PlayerDied;
        }
    }

    public enum BattleResult
    {
        PlayerWon,
        PlayerDied
    }
}
