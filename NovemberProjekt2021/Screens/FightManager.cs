using System;

namespace NovemberProjekt2021
{
    public class FightManager
    {
        public static bool firstFight = true;
        public static bool secondFight = false;
        public static bool thirdFight = false;

        public static void Fights()
        {
            if (firstFight) //om firstFight är true så startar fight1
            {
                secondFight = FightOne();
                System.Console.WriteLine("YES BOSS");
                firstFight = false;
            }

            else if (secondFight && Player.player.GetHp() < 10)
            {

            }

            // bool turnShouldEnd = true;

            // Actor currentActor = Actor.actorQueue.Dequeue(); //gör den längst fram i kön till currentActor


            // turnShouldEnd = currentActor.TakeTurn(); //håller kolla vems tur det är

            // if (turnShouldEnd) //endar en turn och lägger saken längst bak i kön
            // {
            //     Actor.actorQueue.Enqueue(currentActor);
            //     currentActor = Actor.actorQueue.Dequeue();
            // }
        }

        public static bool FightOne()
        {
            Actor.actorQueue.Enqueue(new Graper());
            Actor.actorQueue.Enqueue(new Tuna());
            return true;
        }

        public static bool FightTwo()
        {

            Actor.actorQueue.Clear();
            Actor.actorQueue.Enqueue(Player.player);

            Actor.actorQueue.Enqueue(new Tuna());
            Actor.actorQueue.Enqueue(new Graper());
            Actor.actorQueue.Enqueue(new Graper());
            Actor.actorQueue.Enqueue(new Graper());
            Actor.actorQueue.Enqueue(new Tuna());
            return true;
        }
    }
}