using System;

namespace NovemberProjekt2021
{
    public class Tuna : Boss
    {
        public Tuna()
        {
            Hp = 10;
        }

        public override bool TakeTurn()
        {
            if (Player.player.GetHp() > 10)
            {
                Player.player.PlayerTakeDamage(5);
                System.Console.WriteLine("tuna uses slam");
            }
            else if (Player.player.GetHp() < 10)
            {
                Player.player.PlayerTakeDamage(2);
                System.Console.WriteLine("tuna uses tackle");
            }

            return true;
        }
    }


}