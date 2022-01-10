using System.Collections.Generic;
using System;

namespace NovemberProjekt2021
{
    public class FightManager
    {

        static bool prepFight1 = true;
        static bool prepFight2 = true;
        static bool firstFight = true;
        static bool secondFight = false;
        static bool thirdFight = false;
        public static new List<Actor> killList = new List<Actor>();

        public static void Fights()
        {
            if (killList.Count < 3) //om firstFight är true så startar fight1
            {
                FightOne();
            }

            else if (killList.Count < 8 && killList.Count >= 3)
            {
                FightTwo();
            }
        }

        public static void FightOne()
        {
            if (prepFight1)
            {
                Actor.actorQueue.Enqueue(new Graper());
                Actor.actorQueue.Enqueue(new Tuna());
                System.Console.WriteLine("prepdone");
                prepFight1 = false;
            }
        }

        public static void FightTwo()
        {
            if (prepFight2)
            {
                Actor.actorQueue.Enqueue(new Tuna());
                Actor.actorQueue.Enqueue(new Graper());
                Actor.actorQueue.Enqueue(new Graper());
                Actor.actorQueue.Enqueue(new Graper());
                Actor.actorQueue.Enqueue(new Tuna());
                prepFight2 = false;
            }

            if (true)
            {
                System.Console.WriteLine("fighttwo");
            }
        }
    }
}