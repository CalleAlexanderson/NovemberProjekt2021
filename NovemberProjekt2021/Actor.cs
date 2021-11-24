using System;
using System.Collections.Generic;

namespace NovemberProjekt2021
{
    public class Actor
    {
        public static Queue<Actor> actorQueue = new Queue<Actor>();

        public virtual bool TakeTurn()
        {
            return true;
            // 
        }
    }
}