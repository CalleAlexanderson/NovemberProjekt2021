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

            turnShouldEnd = Actor.currentActor.TakeTurn(); //håller kolla vems tur det är

            while (Player.player.GetHp() > 0)
            {
                FightManager.Fights();



                if (turnShouldEnd) //endar en turn och lägger saken längst bak i kön
                {
                    Actor.actorQueue.Enqueue(Actor.currentActor);
                    Actor.currentActor = Actor.actorQueue.Dequeue();
                }
            }
        }
    }
}
