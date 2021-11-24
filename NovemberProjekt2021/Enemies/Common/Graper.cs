using System;

namespace NovemberProjekt2021
{
    public class Graper : CommonEnemy
    {
        public override bool TakeTurn()
        {
            Console.WriteLine("GraperTurn");
            return true;
        }
    }
}