using System;

namespace NovemberProjekt2021
{
    public class Graper : CommonEnemy
    {
        public Graper()
        {
            Hp = 10;
        }
        public override bool TakeTurn()
        {
            Console.WriteLine("GraperTurn");
            return true;
        }
    }
}