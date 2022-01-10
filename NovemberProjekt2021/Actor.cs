using System;
using System.Collections.Generic;

namespace NovemberProjekt2021
{
    public class Actor
    {
        private bool death = false;
        private int hp;
        protected int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                hp = Math.Max(value, 0);
            }
        }
        public static Queue<Actor> actorQueue = new Queue<Actor>();

        public virtual bool TakeTurn()
        {
            return true;
            // 
        }

        public void update()
        {
            System.Console.WriteLine("update");
            Death();
            AddToKillList();
        }

        public void TakeDamage(int damage)
        {
            Hp = Hp - damage;
        }

        private void Death()
        {
            if (this.Hp == 0)
            {
                death = true;
            }
        }

        public void AddToKillList()
        {
            if (death)
            {
                FightManager.killList.Add(this);
            }
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