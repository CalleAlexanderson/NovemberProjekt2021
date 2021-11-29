using System;
using System.Collections.Generic;

namespace NovemberProjekt2021
{
    public class Actor
    {
        public static Queue<Actor> actorQueue = new Queue<Actor>();
        public static Actor currentActor = Actor.actorQueue.Dequeue(); //gör den längst fram i kön till currentActor

        public virtual bool TakeTurn()
        {
            return true;
            // 
        }

        public static Player FindPlayer()
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