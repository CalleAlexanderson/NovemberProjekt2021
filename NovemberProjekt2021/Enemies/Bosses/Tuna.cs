using System;

namespace NovemberProjekt2021
{
    public class Tuna : Boss
    {
        public override bool TakeTurn()
        {
            Player p = FindPlayer();

            if (p.GetHp() > 10)
            {
                p.PlayerTakeDamage(5);
            }
            else if (p.GetHp() < 10)
            {
                p.PlayerTakeDamage(2);
            }

            return true;
        }
    }


}