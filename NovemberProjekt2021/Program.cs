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
            Player player = new Player();

            bool secondFight = Fight1.FightOne(player);


            bool turnShouldEnd = true;

            Actor currentActor = Actor.actorQueue.Dequeue();

            while (player.GetHp() > 0)
            {
                turnShouldEnd = currentActor.TakeTurn();

                if (turnShouldEnd)
                {
                    Actor.actorQueue.Enqueue(currentActor);
                    currentActor = Actor.actorQueue.Dequeue();
                }
                Console.ReadLine();
            }
        }
    }
}
