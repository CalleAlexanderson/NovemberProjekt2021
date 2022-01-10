using System;
using Raylib_cs;
using System.Collections.Generic;

namespace NovemberProjekt2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // Raylib.InitWindow(800, 600, "game");
            // Raylib.SetTargetFPS(60);

            bool turnShouldEnd = true;

            Actor.actorQueue.Enqueue(new Actor());
            Actor currentActor = Actor.actorQueue.Dequeue(); //gör den längst fram i kön till currentActor


            while (Player.player.GetHp() > 0)
            {
                currentActor.update();
                FightManager.Fights();
                turnShouldEnd = currentActor.TakeTurn(); //håller kolla vems tur det är

                if (turnShouldEnd) //endar en turn och lägger saken längst bak i kön
                {
                    Actor.actorQueue.Enqueue(currentActor);
                    currentActor = Actor.actorQueue.Dequeue();
                }
            }
        }
    }
}
