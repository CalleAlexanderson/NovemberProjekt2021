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


            bool firstFight = true;
            bool turnShouldEnd = true;

            Actor.actorQueue.Enqueue(player); //lägger till spelaren

            Actor currentActor = Actor.actorQueue.Dequeue(); //gör den längst fram i kön till currentActor

            while (player.GetHp() > 0)
            {
                if (firstFight) //om firstFight är true så startar fight1
                {
                    bool secondFight = Fight1.FightOne(player);
                    firstFight = false;
                }


                turnShouldEnd = currentActor.TakeTurn(); //håller kolla vems tur det är

                if (turnShouldEnd) //endar en turn och lägger saken längst bak i kön
                {
                    Actor.actorQueue.Enqueue(currentActor);
                    currentActor = Actor.actorQueue.Dequeue();
                }
                Console.ReadLine();
            }
        }
    }
}
