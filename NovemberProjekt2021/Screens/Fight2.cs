using System.Collections.Generic;
using System;

namespace NovemberProjekt2021
{
    public class Fight2
    {
        public static bool FightTwo(Player player)
        {
            foreach (Actor actor in Actor.actorQueue)
            {
                Actor.actorQueue.Dequeue();
            }
            Actor.actorQueue.Enqueue(player);
            Actor.actorQueue.Enqueue(new Graper());
            Actor.actorQueue.Enqueue(new Graper());
            Actor.actorQueue.Enqueue(new Graper());
            Actor.actorQueue.Enqueue(new Graper());
            Actor.actorQueue.Enqueue(new Tuna());
            return true;
        }
    }
}