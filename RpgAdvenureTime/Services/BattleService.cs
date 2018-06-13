using RpgAdvenureTime.Models;

namespace RpgAdvenureTime.Services
{
    public class BattleService
    {
        // next stop: events!

        public BattleResult Fight(Player player, Monster monster)
        {
            while(true)
            {
                monster.Health = monster.Health - player.Weapon.Damage;

                if (monster.Health < 1)
                    return BattleResult.PlayerWon;

                player.Health = player.Health - monster.Damage;

                if (player.Health < 1)
                    return BattleResult.PlayerDied;
            }
        }
    }

    public enum BattleResult
    {
        PlayerWon,
        PlayerDied
    }
}
