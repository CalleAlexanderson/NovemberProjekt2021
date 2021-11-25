using System;

namespace NovemberProjekt2021
{
    public class Enemy : Actor
    {
        public override bool TakeTurn()
        {
            Console.WriteLine("EnemyTurn");
            return true;
        }
    }
}