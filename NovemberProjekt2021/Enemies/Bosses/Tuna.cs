using System;

namespace NovemberProjekt2021
{
    public class Tuna : Boss
    {
        public override bool TakeTurn()
        {
            if (Player.player.GetHp() > 10)
            {
                Player.player.PlayerTakeDamage(5);
            }
            else if (Player.player.GetHp() < 10)
            {
                Player.player.PlayerTakeDamage(2);
            }

            return true;
        }
    }


}