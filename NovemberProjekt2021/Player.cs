using System;
using Raylib_cs;
using System.Numerics;

namespace NovemberProjekt2021
{
    public class Player : Actor
    {
        // Texture2D playerTexture = Raylib.LoadTexture(@"Red_Wyvern.png");

        public static Player player = new Player();

        public Player()
        {
            Hp = 21;
            Actor.actorQueue.Enqueue(this); //lägger till spelaren
        }

        public int GetHp()
        {
            return Hp;
        }

        public int PlayerTakeDamage(int damage)
        {
            Hp = Hp - damage;
            return Hp;
        }

        public override bool TakeTurn()
        {
            Console.WriteLine("PlayerTurn");
            Console.WriteLine(GetHp());
            string end = Console.ReadLine();
            if (end == "endturn")
            {
                return true;
            }
            return false;

        }


        // public void DrawPlayer()
        // {
        //     // Ritar texturen heroTexture till fönstret, på x-position 40 och 
        //     // y-position 300, utan infärgning (WHITE färgar inte)
        //     // Använd skalning 0.5 och rotation 0.
        //     Vector2 position = new Vector2(40, 300);
        //     Raylib.DrawTextureEx(playerTexture, position, 0, 1, Color.WHITE);
        // }
    }
}