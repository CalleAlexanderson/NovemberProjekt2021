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

        public Player FindPlayer()
        {
            foreach (Actor actor in actorQueue)
            {
                if (actor is Player)
                {
                    return (Player)actor;
                }
            }
            return null;
        }
    }
}