using System.Collections.Generic;
using System;

namespace NovemberProjekt2021
{
    public class Fight2 : Actor
    {
        public static bool FightTwo(Player player)
        {
            Player p = FindPlayer();

            foreach (Actor actor in Actor.actorQueue) //tar bort alla saker i queue förutom player
            {
                if (actor != p)
                {
                    Actor.actorQueue.Dequeue();
                }
            }
            Actor.actorQueue.Enqueue(new Graper());
            Actor.actorQueue.Enqueue(new Graper());
            Actor.actorQueue.Enqueue(new Graper());
            Actor.actorQueue.Enqueue(new Graper());
            Actor.actorQueue.Enqueue(new Tuna());
            return true;
        }
    }
}