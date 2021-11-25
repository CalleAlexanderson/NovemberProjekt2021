using System;

namespace NovemberProjekt2021
{
    public class Fight1
    {
        public static bool FightOne(Player player)
        {
            Actor.actorQueue.Enqueue(new Graper());
            Actor.actorQueue.Enqueue(new Tuna());
            return true;
        }
    }
}